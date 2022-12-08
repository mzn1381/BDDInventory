using System;
using TechTalk.SpecFlow;
	namespace MyNamespace
	{
		[Binding]
		public class StepDefinitions
		{
			private readonly ScenarioContext _scenarioContext;
	
			public StepDefinitions(ScenarioContext scenarioContext)
			{
				_scenarioContext = scenarioContext;
			}
			


[Given(@"I Want To Create (.*) Inventory")]
public void GivenIWantToCreateInventory(string inventoryName)
{
}



[Given(@"The Product And Unti Price Are")]
public void GivenTheProductAndUntiPriceAre(Table table)
{
}

[When(@"I Try To Create New Inventory")]
public void WhenITryToCreateNewInventory()
{
}

[Then(@"The Inventory Is Created And that Must Be Empty")]
public void ThenTheInventoryIsCreatedAndthatMustBeEmpty()
{
}
 }
}