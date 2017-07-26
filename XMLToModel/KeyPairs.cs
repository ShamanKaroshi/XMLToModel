using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XMLToModel
{
    /// <summary>
    /// 
    /// </summary>
    public class KeyPairs
    {
        /// <summary>
        /// 
        /// </summary>
        private IList<KeyPair> keyPairs;
        /// <summary>
        /// 
        /// </summary>
        public KeyPairs()
        {
            keyPairs = new List<KeyPair>();
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <param name="value"></param>
        /// <returns></returns>
        public KeyPair Add(string key, string value)
        {
            KeyPair kp = new KeyPair();
            kp.key = key;
            kp.value = value;
            this.keyPairs.Add(kp);
            return kp;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public int Count()
        {
            return this.keyPairs.Count;
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="index"></param>
        /// <returns></returns>
        public KeyPair Get(int index)
        {
            return this.keyPairs[index];
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="key"></param>
        /// <returns></returns>
        public KeyPair Find(string key)
        {
            var retValue = from p in keyPairs
                        where p.key == key
                        select p;
            return (KeyPair)retValue;
        }
    }
}
