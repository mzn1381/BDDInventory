@Inventory
Feature: Define New Inventory
As a Warehouse Keeper Manager 
IWant To Create New Inventory
So That I should Be able to Create New Inventory


Scenario: Created Inventory
	Given I Want To Create "IPhone" Inventory 
	And The Product And Unti Price Are 
    | Product   | Unit Price | Count |
    | IPhone 12 | 255000     |  12   |
	When I Try To Create New Inventory
	Then The Inventory Is Created And that Must Be Empty
	

