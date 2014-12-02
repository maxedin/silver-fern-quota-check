using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Win32;
using System.Collections;

namespace SilverFernCheckerCore.Settings
{

    public class RegistrySettings
    {
        public RegistrySettings(string baseKey)
        {
            this.keyName = baseKey;
        }

        public bool ISMACHINE { get; set; }

        public bool KeyExist()
        {
            RegistryKey subKey = ISMACHINE ? Registry.LocalMachine.OpenSubKey(keyName.Replace("HKEY_LOCAL_MACHINE\\", "")) : Registry.CurrentUser.OpenSubKey(keyName.Replace("HKEY_CURRENT_USER\\", ""));
            return subKey != null;
        }

        public string[] GetSubKeys()
        {
            if (KeyExist())
            {
                return ISMACHINE ? Registry.LocalMachine.OpenSubKey(keyName.Replace("HKEY_LOCAL_MACHINE\\", "")).GetSubKeyNames() : Registry.CurrentUser.OpenSubKey(keyName.Replace("HKEY_CURRENT_USER\\", "")).GetSubKeyNames();
            }
            return new string[] {};
        }


        public RegistrySettings(RegistrySettings parent, string name)
        {
            if (parent != null)
                this.keyName = parent.keyName + "\\" + name;
            else keyName = name;
        }

        public string GetValue(string valueName, string defaultValue)
        {
            string val = (string)Registry.GetValue(keyName, valueName, defaultValue);
            return val == null ? defaultValue : val;
        }

        public byte[] GetValue(string valueName, byte[] defaultValue)
        {
            byte[] val = (byte[])Registry.GetValue(keyName, valueName, defaultValue);
            return val ?? defaultValue;
        }

        public void SetValue(string valueName, string value)
        {
            Registry.SetValue(keyName, valueName, value);
        }

        public void SetValue(string valueName, byte[] value)
        {
            Registry.SetValue(keyName, valueName, value,RegistryValueKind.Binary);
        }

        public bool GetValue(string valueName, bool defaultValue)
        {
            object x = Registry.GetValue(keyName, valueName, (object)(defaultValue ? 1 : 0));
            return x == null ? defaultValue : (int)x != 0;
        }

        public void SetValue(string valueName, bool value)
        {
            Registry.SetValue(keyName, valueName, value ? 1 : 0, RegistryValueKind.DWord);
        }

        public int GetValue(string valueName, int defaultValue)
        {
            object x = Registry.GetValue(keyName, valueName, defaultValue);
            return x == null ? defaultValue : (int)x;
        }

        public void SetValue(string valueName, int value)
        {
            Registry.SetValue(keyName, valueName, value, RegistryValueKind.DWord);
        }

        public DateTime GetValue(string valueName, DateTime defaultValue)
        {
            object ticks = Registry.GetValue(keyName, valueName, defaultValue.Ticks);
            return ticks == null ? defaultValue : new DateTime((long)ticks);
        }

        public void SetValue(string valueName, DateTime value)
        {
            Registry.SetValue(keyName, valueName, value.Ticks, RegistryValueKind.QWord);
        }
        

        public int[] GetIntListValue(string valueName)
        {
            string val = (string)Registry.GetValue(keyName, valueName, "");
            if (string.IsNullOrEmpty(val))
            {
                return new int[0];
            }
            else
            {
                List<int> result = new List<int>();
                string[] vals = val.Split(',');
                foreach (string s in vals)
                {
                    int x;
                    if (int.TryParse(s, out x))
                        result.Add(x);
                }
                return result.ToArray();
            }
        }

        public void SetListValue(string valueName, IEnumerable list)
        {
            StringBuilder b = new StringBuilder();
            foreach (object x in list)
                if (b.Length > 0)
                    b.Append("," + x.ToString());
                else
                    b.Append(x.ToString());
            Registry.SetValue(keyName, valueName, b.ToString());
        }
        public string KeyName
        {
            get { return keyName; }
        }

        private string keyName;
    }

    
}
