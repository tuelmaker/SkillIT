using SkillIT.Models;
using SkillITForm;
using System.IO.IsolatedStorage;

namespace SkillIT
{
    /// <summary>
    /// Class to handle the isolated storage of the options
    /// </summary>
    internal class IsolatedStorageOptions
    {
        /// <summary>
        /// Set the options in isolated storage and return them back
        /// </summary>
        /// <param name="options"></param>
        /// <returns></returns>
        public void SetIsolatedStorage(OptionsModel options)
        { 
            using (IsolatedStorageFile storage = IsolatedStorageFile.GetUserStoreForAssembly())
            {
                using (IsolatedStorageFileStream stream = new IsolatedStorageFileStream(Constants.ISOLATED_STORAGE_FILE_JSON, System.IO.FileMode.Create, storage))
                {
                    using (System.IO.StreamWriter writer = new System.IO.StreamWriter(stream))
                    {
                        writer.Write(Newtonsoft.Json.JsonConvert.SerializeObject(options));
                    }
                }
            }          

        }

        /// <summary>
        /// Retrieve the options from isolated storage
        /// </summary>
        /// <returns><see cref="OptionsModel"/></returns>
        public OptionsModel GetIsolatedStorage()
        {
            OptionsModel options = new OptionsModel();
            using (IsolatedStorageFile storage = IsolatedStorageFile.GetUserStoreForAssembly())
            {
                if (storage.FileExists(Constants.ISOLATED_STORAGE_FILE_JSON))
                {
                    using (IsolatedStorageFileStream stream = new IsolatedStorageFileStream(Constants.ISOLATED_STORAGE_FILE_JSON, System.IO.FileMode.Open, storage))
                    {
                        using (System.IO.StreamReader reader = new System.IO.StreamReader(stream))
                        {
                            options = Newtonsoft.Json.JsonConvert.DeserializeObject<OptionsModel>(reader.ReadToEnd());
                        }
                    }
                }
            }
            return options;
        }
    }
}
