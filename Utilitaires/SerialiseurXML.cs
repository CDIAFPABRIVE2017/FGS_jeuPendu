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

      
             
              public void Save(string pathRepData, IEnumerable objetASauvegarder)
        {
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
             
              public IEnumerable Load(string pathRepData, Type typeACharger)
        {
            Object objet = null;

            string pathXmlDocument = string.Format("{0}\\{1}.Xml", pathRepData, typeACharger.FullName);
            if (File.Exists(pathXmlDocument))
            {

                using (FileStream fileStream = new FileStream(pathXmlDocument, FileMode.Open, FileAccess.Read, FileShare.Read))
                {

                    XmlTextReader xmlTR = new XmlTextReader(fileStream);
                    XmlSerializer xmlS = new XmlSerializer(typeACharger);

                    objet = xmlS.Deserialize(xmlTR);
                    xmlTR.Close();
                    fileStream.Close();
                }

                return objet as IEnumerable;
            }
            return null;
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