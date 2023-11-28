using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO.IsolatedStorage;
using SkillIT.Models;
using SkillITForm;

namespace SkillIT
{
    internal class IsolatedStorageOptions
    {
        public OptionsModel SetIsolatedStorage(OptionsModel options)
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
            return options;

        }

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
