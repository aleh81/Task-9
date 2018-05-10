using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Task9.BLL.Helpers;

namespace Task9.Bll.Tests.Helpers
{
	[TestFixture]
	class FileHelperTest
	{
		[Test]
		public void TestSaveFileDialog()
		{
				Assert.Catch<NullReferenceException>
				(InitNullOfArgumentFor_SaveFileMethod);
		}

		private void InitNullOfArgumentFor_SaveFileMethod()
		{
			FileHelper.SaveFileDialog(null);
		}

		[Test]
		public void TestSaveFile()
		{
	
		}

	}
}
