using System.Collections.Generic;

namespace com.asf.declarantbrige.model {
    public abstract class AbstractModel {

        private Dictionary<string, object> propertyValues = new Dictionary<string, object>();

        public object getProperty(string key) {
            if (propertyValues.ContainsKey(key)) {
                return propertyValues[key];
            }
            return null;
        }

        public void setProperty(string key, object value) {
            if(propertyValues.ContainsKey(key))
            {
                propertyValues[key] = value;
            }
            else
            {
                propertyValues.Add(key, value);
            }
        }

        public string getString(string key)
        {
            object value = getProperty(key);
            if(value == null)
            {
                return string.Empty;
            }
            return value.ToString();
        }

        public int getInt(string key) {
            return (int) getProperty(key);
        }


    }
}
