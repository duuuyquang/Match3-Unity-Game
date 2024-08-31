Project's design and organization:
- Advantages:
	+ scripts and assets are arrange in separated folder with clear naming, easy to handle parts need to work with.
	+ apply Observer Pattern that help managing game events triggering better.
	+ UI Manager is clear.
- Disadvantages:
	+ missing Singleton applied on manager scripts for easier globally usage.
	+ Object's type defination abit rambling so that take quiet sometime to connect them together and take more steps to check for each type ( Exp: NormalItem vs BonusItem )
	+ Use resources to store prefabs may take more memories if the project scales bigger.
	