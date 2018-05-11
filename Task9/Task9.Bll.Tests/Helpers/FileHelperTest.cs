using System;
using NUnit.Framework;
using Task9.BLL.Helpers;
using Task9.BLL.Services;
using Task9.BLL.Services.Interfaces;

namespace Task9.Bll.Tests.Helpers
{
	[TestFixture]
	class FileHelperTest
	{
		private IFileManager _fileManager;

		[SetUp]
		public void Init()
		{
			_fileManager = new FileManager();
		}
		[Test]
		public void TestSaveFileDialog()
		{
			Assert.Catch<NullReferenceException>
			(InitNullOfArgumentFor_SaveFileMethod);
		}

		private void InitNullOfArgumentFor_SaveFileMethod()
		{
			var fileHelper = new FileHelper(_fileManager);
		    fileHelper.SaveFileDialog(null);
		}
	}
}
