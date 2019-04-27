using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace BasicAccount
{
    public static class AccountDB
    {
        private const string Path = @"..\..\Accounts.xml";

        public static List<BasicAccount> GetAccounts()
        {
            // create the list
            List<BasicAccount> accounts = new List<BasicAccount>();

            // create the XmlReaderSettings object
            XmlReaderSettings settings = new XmlReaderSettings();
            settings.IgnoreWhitespace = true;
            settings.IgnoreComments = true;

            // create the XmlReader object
            XmlReader xmlIn = XmlReader.Create(Path, settings);

            // read past all nodes to the first Account node
            if (xmlIn.ReadToDescendant("Account"))
            {
                // create one Account object for each Account node
                do
                {
                    BasicAccount account;
                    xmlIn.ReadStartElement("Account");
                    string type =
                        xmlIn.ReadElementContentAsString();
                    if (type == "Saving")
                    {
                        account = ReadSavingsAccount(xmlIn);
                    }
                    else    // type == "Checking"
                    {
                        account = ReadCheckingAccount(xmlIn);
                    }
                    accounts.Add(account);
                }
                while (xmlIn.ReadToNextSibling("Account"));
            }
            
            // close the XmlReader object
            xmlIn.Close();

            return accounts;
        }

        private static SavingsAccount ReadSavingsAccount(XmlReader xmlIn)
        {
            SavingsAccount s = new SavingsAccount();
            ReadBase(xmlIn, s);
            s.MinimumBalance =
                xmlIn.ReadElementContentAsDecimal();
            return s;
        }

        private static CheckingAccount ReadCheckingAccount(XmlReader xmlIn)
        {
            CheckingAccount c = new CheckingAccount();
            ReadBase(xmlIn, c);
            c.OverdraftLimit =
                xmlIn.ReadElementContentAsDecimal();
            return c;
        }

        private static void ReadBase(XmlReader xmlIn, BasicAccount b)
        {
            b.AccountNumber =
                xmlIn.ReadElementContentAsInt();
            b.Owner =
                xmlIn.ReadElementContentAsString();
            b.Balance =
                xmlIn.ReadElementContentAsDecimal();
            b.InterestRate =
                xmlIn.ReadElementContentAsFloat();
        }

        public static void SaveAccounts(List<BasicAccount> accounts)
        {
            // create the XmlWriterSettings object
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            settings.IndentChars = ("    ");

            // create the XmlWriter object
            XmlWriter xmlOut = XmlWriter.Create(Path, settings);

            // write the start of the document
            xmlOut.WriteStartDocument();
            xmlOut.WriteStartElement("Accounts");

            // write each product object to the xml file
            foreach (BasicAccount account in accounts)
            {
                if (account.GetType().Name == "SavingsAccount")
                    WriteSavingsAccount((SavingsAccount)account, xmlOut);
                else if (account.GetType().Name == "CheckingAccount")
                    WriteCheckingAccount((CheckingAccount)account, xmlOut);
            }

            // write the end tag for the root element
            xmlOut.WriteEndElement();

            // close the xmlWriter object
            xmlOut.Close();
        }
        private static void WriteSavingsAccount(SavingsAccount account,
            XmlWriter xmlOut)
        {
            xmlOut.WriteStartElement("Account");
            xmlOut.WriteElementString("Type", "Saving");
            WriteBase(account, xmlOut);
            xmlOut.WriteElementString("MinimumBalance",
                Convert.ToString(account.MinimumBalance));
            xmlOut.WriteEndElement();
        }

        private static void WriteCheckingAccount(CheckingAccount account,
            XmlWriter xmlOut)
        {
            xmlOut.WriteStartElement("Account");
            xmlOut.WriteElementString("Type", "Checking");
            WriteBase(account, xmlOut);
            xmlOut.WriteElementString("OverdraftLimit",
                Convert.ToString(account.OverdraftLimit));
            xmlOut.WriteEndElement();
        }

        private static void WriteBase(BasicAccount account,
            XmlWriter xmlOut)
        {
            xmlOut.WriteElementString("AccountNumber",
                Convert.ToString(account.AccountNumber));
            xmlOut.WriteElementString("Owner",
                account.Owner);
            xmlOut.WriteElementString("Balance",
                Convert.ToString(account.Balance));
            xmlOut.WriteElementString("InterestRate",
                Convert.ToString(account.InterestRate));
        }
    }
}
