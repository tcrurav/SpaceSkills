# Skills Space Orientation Experience 

A unity project with Videos and some 3D models to show in the next Skills meeting in the Canary Islands.

## Getting Started

These instructions will give you a copy of the project up and running on your local machine for development and testing purposes.

### Prerequisites

You need a working environment with:
* [Git](https://git-scm.com) - You can install it from https://git-scm.com/downloads.
* [Unity](https://store.unity.com/es/download) - Install Unity Personal from https://store.unity.com/es/download.

## General Installation instructions

The best option to start with this project is cloning it in your PC:

```
git clone https://github.com/tcrurav/SpaceSkills.git
```

Just open the project with Unity Editor and run the scene `SciFiCorridorScene`.

Take into account that you should have some Videos to show in folder Assets\Resources\Videos360.

Each video should have:
* A video file in the form Video-n.mp4 (`n` is a number starting with 1)
* A thumbnail foto file in the form Thumbnail-n.mp4

You have to edit title and description for every video in Assets/Scripts/PanelManager.cs/InitializePanels() as well.

You can download some 360 Videos examples from here: https://drive.google.com/drive/folders/1WS5Vu4Fztd64TFJMSjS_MKz_m_PjsKMk?usp=sharing

Enjoy!!!

## Built With

* [Unity](https://unity.com/es) - A 3D and 2D motor engine to develop games.

## Acknowledgments

* https://learn.unity.com/course/create-with-vr. Unity VR Basics tutorial to start creating VR with Unity.
* https://learn.unity.com/tutorial/play-360-video-with-a-skybox-in-unity#5feba386edbc2a76a4c72dbb. Play 360 Video with a Skybox in Unity.
* https://www.youtube.com/watch?v=674k6lHqpPc. How to Add Images to Buttons in Unity.
* https://gist.github.com/PurpleBooth/109311bb0361f32d87a2. A very complete template for README.md files.