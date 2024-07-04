﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace vCard
{
    public class VCardSaver

     public class VCardSaver
    {
        public void SaveToFile(VCard vcard, string directory)
        {
            if (!Directory.Exists(directory))
            {
                Directory.CreateDirectory(directory);
            }

            string filePath = Path.Combine(directory, $"{vcard.Id}.vcf");
            File.WriteAllText(filePath, vcard.ToString());
        }
    }

}
