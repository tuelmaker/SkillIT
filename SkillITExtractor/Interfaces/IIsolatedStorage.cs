using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SkillIT.Interfaces
{
    internal interface IIsolatedStorage
    {

        /// <summary>
        /// Save the object to isolated storage
        /// </summary>
        /// <param name="objectToSave"></param>
        /// <param name="fileName"></param>
        void SaveObjectToIsolatedStorage(object objectToSave, string fileName);

        /// <summary>
        /// Load the object from isolated storage
        /// </summary>
        /// <param name="fileName"></param>
        /// <returns></returns>
        object LoadObjectFromIsolatedStorage(string fileName);

        /// <summary>
        /// Delete the object from isolated storage
        /// </summary>
        /// <param name="fileName"></param>
        void DeleteObjectFromIsolatedStorage(string fileName);
    }
}
