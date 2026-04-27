Scene Loader Manager Package
----------------------------

Hi! Welcome the Scene Loader Manager Package readme. This package allows you to simply trigger scene loading from any of your custom method!


Generic Requirement
-----------

* Have more than 1 Scene in your project

* Have 1 instance of SceneLoaderManager script in your initial scene
* Have 1 instance of SceneLoaderTrigger script in your initical scene

-> The SceneLoaderPrefab already has those two scripts, you could simply drag&drop this prefab


Use with Code
-------------
	Requirement
	-----------
	* Have prepared your Method/Event that will launch the scene loading
			(in the example, this would be the 'OnTriggerEnter' method in the 'Trigger' script which is attached to the TriggerZone)


	Use
	---

	1. In the Script that has your Method, declare (see Requirements) ->
		[SerializeField] SceneLoaderTrigger sceneLoaderTrigger;

	2. In your Method/Event, call ->
		sceneLoaderTrigger.LaunchLoadEvent("NameOfSceneYouWantToLoad");

		/!\ The method 'sceneLoaderTrigger.LaunchLoadEvent' expects a string which is the exact name of the scene you would like to load /!\
			(in the exampe, this string would be 'FinalExampleScene') 

	3. In your Inspector, On the GameObject that has your Script & Method ->
		Drag&Drop the GameObject SceneLoaderTrigger as Reference for "Scene Load Trigger"
			(in the example, check in the inspector this GameObject would be 'TriggerZone' which has a Reference to SceneLoaderTrigger)


That's it ! Hit Play and trigger your method/event to see the magic happen

Example
-------
An example is provided in the final scene.
To try it, load the 'InitialExampleScene' and hit play. Use the Scene Viewport and use the gizmo to drag the sphere onto the plane (TriggerZone)

This example uses a onTriggerEnter but it could be whatever you want ! A button, an in-world interaction, an event, ...

