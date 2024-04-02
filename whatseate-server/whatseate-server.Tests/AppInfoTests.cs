using NUnit.Framework;
using whatseate_server;

namespace whatseate_server.Tests;

public class AppInfoTests
{
	[SetUp]
	public void Setup()
	{
	}

	[Test]
	public void AppInfoCreation()
	{
		var appInfo = new AppInfo { Title = "Test" };

		Assert.AreEqual("Test", appInfo.Title);
	}
}
