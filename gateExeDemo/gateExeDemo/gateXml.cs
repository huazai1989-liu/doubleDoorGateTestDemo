using System;
using System.IO;
using System.Xml;

namespace nsGateXml
{
    public class gateXml
    {
        public static void test()
        {
            ////创建Xml文档。
            //XmlDocument xmlDocument = new XmlDocument();
            //xmlDocument.LoadXml(xml);
            //creatXmlHeader();
        }

        public static void dealGateCmd(string xmlData)
        {

        }

        /// <summary>
        /// 将XmlDocument转化为string
        /// </summary>
        /// <param name="xmlDoc"></param>
        /// <returns></returns>
        public static string ConvertXmlToString(XmlDocument xmldoc)
        {
            StringWriter sw = new StringWriter();
            XmlTextWriter xmlTextWriter = new XmlTextWriter(sw);
            xmldoc.WriteTo(xmlTextWriter);
           
            return sw.ToString();
        }

        public static bool addXmlNode(ref XmlDocument xmldoc, XmlElement node)
        {
            bool ret = false;

            do
            {
                //XmlDocument xmldoc = new XmlDocument();
                //xmldoc.LoadXml(s_xml);

                XmlNode root = xmldoc.SelectSingleNode("envelope");
                if (root != null)
                {

                }
                else
                {
                    break;
                }
                root.AppendChild(node);//添加到节点中

                //s_xml_new = ConvertXmlToString(xmldoc);
                ret = true;
            } while (false);

            return ret;
        }
        public static bool creatXmlHeader(ref XmlDocument xmldoc)
        {
            bool ret = false;
            //XmlDocument xmldoc = null;
            XmlElement xmlelem = null;

            do
            {
                //xmldoc = new XmlDocument();
                //加入XML的声明段落,<?xml version="1.0" encoding="UTF-8"?>
                XmlDeclaration xmldecl;
                xmldecl = xmldoc.CreateXmlDeclaration("1.0", "UTF-8", null);
                xmldoc.AppendChild(xmldecl);

                //加入一个根元素
                xmlelem = xmldoc.CreateElement("", "envelope", "");
                xmldoc.AppendChild(xmlelem);
                //加入另外一个元素


                XmlNode root = xmldoc.SelectSingleNode("envelope");//查找<Employees>
                if (root != null)
                {
                    XmlElement xe1 = xmldoc.CreateElement("header");//创建一个<Node>节点

                    XmlElement xesub1 = xmldoc.CreateElement("funcNo");
                    xesub1.InnerText = "request";//设置文本节点
                    xe1.AppendChild(xesub1);//添加到<Node>节点中
                    XmlElement xesub2 = xmldoc.CreateElement("tranTime");
                    xesub2.InnerText = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss"); ;
                    xe1.AppendChild(xesub2);
                    XmlElement xesub3 = xmldoc.CreateElement("version");
                    xesub3.InnerText = "1.0";
                    xe1.AppendChild(xesub3);

                    root.AppendChild(xe1);//添加到<Employees>节点中
                }
                else
                {
                    break;
                }

                //s_xml = ConvertXmlToString(xmldoc);

                ret = true;
            } while (false);

            return ret;
        }

        public static string gateCmdInit()
        {
            string ret = null;

            do
            {
                XmlDocument xmldoc = null;

                xmldoc = new XmlDocument();

                creatXmlHeader(ref xmldoc);

                XmlElement xe1 = xmldoc.CreateElement("body");//创建一个<Node>节点

                XmlElement xesub1 = xmldoc.CreateElement("command");
                xesub1.InnerText = "CR";//设置文本节点
                xe1.AppendChild(xesub1);//添加到<Node>节点中

                addXmlNode(ref xmldoc,xe1);
                ret = ConvertXmlToString(xmldoc);
            } while (false);

            return ret;
        }

        public static string gateCmdSetEp(int f,int s,int t)
        {
            string ret = null;

            do
            {
                XmlDocument xmldoc = null;

                xmldoc = new XmlDocument();

                creatXmlHeader(ref xmldoc);

                XmlElement xe1 = xmldoc.CreateElement("body");//创建一个<Node>节点

                XmlElement xesub1 = xmldoc.CreateElement("command");
                xesub1.InnerText = "EP";//设置文本节点
                xe1.AppendChild(xesub1);//添加到<Node>节点中


                if(f>=0 || s>=0 || t>=0)
                {
                    XmlElement xe2 = xmldoc.CreateElement("data");//创建一个<Node>节点
                    if (f>=0)
                    {                       
                        XmlElement xesub2 = xmldoc.CreateElement("firstTimeout");
                        xesub2.InnerText = f.ToString();//设置文本节点
                        xe2.AppendChild(xesub2);//添加到<Node>节点中
                    }
                    if (s >= 0)
                    {
                        XmlElement xesub2 = xmldoc.CreateElement("secondTimeout");
                        xesub2.InnerText = s.ToString();//设置文本节点
                        xe2.AppendChild(xesub2);//添加到<Node>节点中
                    }
                    if (t >= 0)
                    {
                        XmlElement xesub2 = xmldoc.CreateElement("timeout");
                        xesub2.InnerText = t.ToString();//设置文本节点
                        xe2.AppendChild(xesub2);//添加到<Node>节点中
                    }
                    xe1.AppendChild(xe2);//添加到<Node>节点中
                }



                addXmlNode(ref xmldoc, xe1);
                ret = ConvertXmlToString(xmldoc);
            } while (false);

            return ret;
        }

        public static string gateCmdSetDoorTyep(int first,int second)
        {
            string ret = null;

            do
            {
                XmlDocument xmldoc = null;

                xmldoc = new XmlDocument();

                creatXmlHeader(ref xmldoc);

                XmlElement xe1 = xmldoc.CreateElement("body");//创建一个<Node>节点

                XmlElement xesub1 = xmldoc.CreateElement("command");
                xesub1.InnerText = "CB";//设置文本节点
                xe1.AppendChild(xesub1);//添加到<Node>节点中

                XmlElement xe2 = xmldoc.CreateElement("data");//创建一个<Node>节点

                XmlElement xesub2 = xmldoc.CreateElement("firstType");
                xesub2.InnerText = first.ToString();//设置文本节点
                xe2.AppendChild(xesub2);//添加到<Node>节点中
                XmlElement xesub3 = xmldoc.CreateElement("secondType");
                xesub3.InnerText = second.ToString();//设置文本节点
                xe2.AppendChild(xesub3);//添加到<Node>节点中

                xe1.AppendChild(xe2);//添加到<Node>节点中

                addXmlNode(ref xmldoc, xe1);
                ret = ConvertXmlToString(xmldoc);
            } while (false);

            return ret;
        }


        public static string gateCmdOpenDoor(int first, int second)
        {
            string ret = null;

            do
            {
                XmlDocument xmldoc = null;

                xmldoc = new XmlDocument();

                creatXmlHeader(ref xmldoc);

                XmlElement xe1 = xmldoc.CreateElement("body");//创建一个<Node>节点

                XmlElement xesub1 = xmldoc.CreateElement("command");
                xesub1.InnerText = "CC";//设置文本节点
                xe1.AppendChild(xesub1);//添加到<Node>节点中

                XmlElement xe2 = xmldoc.CreateElement("data");//创建一个<Node>节点

                XmlElement xesub2 = xmldoc.CreateElement("handleType");
                xesub2.InnerText = first.ToString();//设置文本节点
                xe2.AppendChild(xesub2);//添加到<Node>节点中
                XmlElement xesub3 = xmldoc.CreateElement("direction");
                xesub3.InnerText = second.ToString();//设置文本节点
                xe2.AppendChild(xesub3);//添加到<Node>节点中

                xe1.AppendChild(xe2);//添加到<Node>节点中

                addXmlNode(ref xmldoc, xe1);
                ret = ConvertXmlToString(xmldoc);
            } while (false);

            return ret;
        }

        public static string gateCmdStatus()
        {
            string ret = null;

            do
            {
                XmlDocument xmldoc = null;

                xmldoc = new XmlDocument();

                creatXmlHeader(ref xmldoc);

                XmlElement xe1 = xmldoc.CreateElement("body");//创建一个<Node>节点

                XmlElement xesub1 = xmldoc.CreateElement("command");
                xesub1.InnerText = "SQ";//设置文本节点
                xe1.AppendChild(xesub1);//添加到<Node>节点中

                addXmlNode(ref xmldoc, xe1);
                ret = ConvertXmlToString(xmldoc);
            } while (false);

            return ret;
        }
        public static string gateCmdAlarm()
        {
            string ret = null;

            do
            {
                XmlDocument xmldoc = null;

                xmldoc = new XmlDocument();

                creatXmlHeader(ref xmldoc);

                XmlElement xe1 = xmldoc.CreateElement("body");//创建一个<Node>节点

                XmlElement xesub1 = xmldoc.CreateElement("command");
                xesub1.InnerText = "CO";//设置文本节点
                xe1.AppendChild(xesub1);//添加到<Node>节点中

                addXmlNode(ref xmldoc, xe1);
                ret = ConvertXmlToString(xmldoc);
            } while (false);

            return ret;
        }
        public static string gateCmdDiscon()
        {
            string ret = null;

            do
            {
                XmlDocument xmldoc = null;

                xmldoc = new XmlDocument();

                creatXmlHeader(ref xmldoc);

                XmlElement xe1 = xmldoc.CreateElement("body");//创建一个<Node>节点

                XmlElement xesub1 = xmldoc.CreateElement("command");
                xesub1.InnerText = "DISCON";//设置文本节点
                xe1.AppendChild(xesub1);//添加到<Node>节点中

                addXmlNode(ref xmldoc, xe1);
                ret = ConvertXmlToString(xmldoc);
            } while (false);

            return ret;
        }
    }
}

