using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using System.Globalization;
using System.Runtime.Serialization;
using System.IO;
using System.Collections;
using System.Runtime.Serialization.Formatters.Binary;


namespace Utilitaires
{
   
    public class SauvegardeXML : ISauvegarde
    {

    
        /// <summary>
        /// Sauvegarder par sérialisation Xml 
        /// </summary>
        /// <param name="pathRepData"></param>
        /// <param name="objetASauvegarder"></param>
        public void Save(string pathRepData, IEnumerable objetASauvegarder)
        {

            // Enregistrer le fichier text
            string extention = string.Empty;
            if (pathRepData.Length >= 4)
            {
                extention = pathRepData.Substring(pathRepData.Length - 4, 4).ToString().Trim();
            }

            if (string.Equals(extention, ".txt"))
            {
                using (StreamWriter sw = new StreamWriter(pathRepData))
                {
                    foreach(string item in objetASauvegarder)
                    sw.WriteLine(item);

            sw.Close();
                }
  

            }
            else
            {
                // Enregistrer le fichier xml
                Type type = objetASauvegarder.GetType();

            string pathXmlDocument = string.Format("{0}\\{1}.Xml", pathRepData, type.FullName);
            using (FileStream fileStream = new FileStream(pathXmlDocument, FileMode.Create, FileAccess.Write, FileShare.Read))
            {
                XmlTextWriter xmlTW = new XmlTextWriter(fileStream, Encoding.UTF8);
                XmlSerializer xmlS = new XmlSerializer(type);
                xmlS.Serialize(xmlTW, objetASauvegarder);
                xmlTW.Close();
                fileStream.Close();
            }
            }
        }
        /// <summary>
        /// Extraire les données par désérialisation XML
        /// </summary>
        /// <param name="pathRepData"></param>
        /// <param name="typeACharger"></param>
        /// <returns></returns>
        public IEnumerable Load(string pathRepData, Type typeACharger)
        {
            Object objet = new object();
            // lire fichier text
            string extention = pathRepData.Substring(pathRepData.Length - 4, 4).ToString().Trim();
           if (string.Equals(extention, ".txt") )
            {
                List<string> lst = new List<string>();
                using (var fileStream = File.OpenRead(pathRepData))
                using (var streamReader = new StreamReader(fileStream, Encoding.UTF8, true))
                {
                    String line;
                    while ((line = streamReader.ReadLine()) != null)
                    {
                        lst.Add(line);
                    }
                    fileStream.Close();
                    streamReader.Close();
                    return lst as IEnumerable;
                }
            }
           else
            {
            //lecture fichier xml
            string pathXmlDocument = string.Format("{0}\\{1}.Xml", pathRepData, typeACharger.FullName);
            if (!File.Exists(pathXmlDocument))
            {
                File.Create(pathXmlDocument);
                      
            }

           
            using (FileStream fileStream = new FileStream(pathXmlDocument, FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                if ((fileStream.Length > 0))
                {
                    XmlTextReader xmlTR = new XmlTextReader(fileStream);
                    XmlSerializer xmlS = new XmlSerializer(typeACharger);

                    objet = xmlS.Deserialize(xmlTR);
                    xmlTR.Close();
                }
                
                fileStream.Close();
                }
            }

            return objet as IEnumerable;
        }
    }
    sealed class BinderType : SerializationBinder
    {

        public override Type BindToType(string assemblyName, string typeName)
        {
            Type typeToDeserialize = null;
            typeToDeserialize = Type.GetType(assemblyName);

            return typeToDeserialize;
        }
    }
}
