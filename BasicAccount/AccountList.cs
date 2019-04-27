using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicAccount
{

    public class AccountList : List<BasicAccount>
	{
		// Modify the behavior of the Add method of the List<> class
		public new void Add(BasicAccount b)
		{
			base.Insert(0, b);
		}

		// Provide two additional methods
		public void Fill()
		{
			List<BasicAccount> accounts = AccountDB.GetAccounts();
			foreach (BasicAccount account in accounts)
				base.Add(account);
		}

		public void Save()
		{
			AccountDB.SaveAccounts(this);
		}
	}
}
