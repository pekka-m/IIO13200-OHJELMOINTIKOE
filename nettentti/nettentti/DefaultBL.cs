using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Xml;

/// <summary>
/// Summary description for DefaultBL
/// </summary>
public class DefaultBL
{
    public DefaultBL()
    {
        //
        // TODO: Add constructor logic here
        //
    }

    public bool tryLogin(string username, string password)
    {

        Dictionary<string, string> credentials = new Dictionary<string, string>();

        XmlDocument doc = new XmlDocument();
        string fileName = HttpContext.Current.Server.MapPath("~/App_Code/credentials.xml");
        doc.Load(fileName);
        XmlElement root = doc.DocumentElement;
        XmlNodeList nodes = root.SelectNodes("user");
        foreach (XmlNode node in nodes)
        {
            credentials.Add(node["name"].InnerText, node["password"].InnerText);
        }

        foreach (var item in credentials)
        {
            if (item.Key == username && item.Value == password)
            {
                return true;
            }
        }

        return false;
    }
}