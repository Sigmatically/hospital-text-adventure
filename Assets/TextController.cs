using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class TextController : MonoBehaviour {

	public Text text;
	// public Text text2;

	private enum States {
		title, hospital_bed, hospital_bed_room, desk_0, monitor_0, chair, door_0, window_0, hospital_bed_chair, monitor_1, desk_1, door_1, window_1, hallway_middle,
		room_223, room_223_monitor, room_223_desk, room_224, room_224_desk, room_224_monitor, room_225, room_225_desk, room_225_monitor, hallway_upstairs, hallway_downstairs,
		dry_wall_entrance, lab, lab_monitor, lab_bed
	}

	private States myState;

	private bool gotUp = false;
	private bool throughWindow = false;
	private bool hasHook = false;


	// Use this for initialization
	void Start ()
	{
		myState = States.title;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if 		(myState == States.title) 				{title();}
		else if (myState == States.hospital_bed) 		{hospital_bed();}
		else if (myState == States.hospital_bed_room) 	{hospital_bed_room();}
		else if (myState == States.desk_0) 				{desk_0();}
		else if (myState == States.monitor_0) 			{monitor_0();}
		else if (myState == States.chair) 				{chair();}
		else if (myState == States.door_0) 				{door_0();}
		else if (myState == States.window_0) 			{window_0();}
		else if (myState == States.hospital_bed_chair) 	{hospital_bed_chair();}
		else if (myState == States.desk_1) 				{desk_1();}
		else if (myState == States.monitor_1) 			{monitor_1();}
		else if (myState == States.door_1) 				{door_1();}
		else if (myState == States.window_1) 			{window_1();}
		else if (myState == States.hallway_middle) 		{hallway_middle();}
		else if (myState == States.room_223) 			{room_223();}
		else if (myState == States.room_223_monitor) 	{room_223_monitor();}
		else if (myState == States.room_223_desk) 		{room_223_desk();}
		else if (myState == States.room_224) 			{room_224();}
		else if (myState == States.room_224_desk) 		{room_224_desk();}
		else if (myState == States.room_224_monitor) 	{room_224_monitor();}
		else if (myState == States.dry_wall_entrance) 	{dry_wall_entrance();}
		else if (myState == States.lab) 				{lab();}
		else if (myState == States.lab_monitor) 		{lab_monitor();}
		else if (myState == States.lab_bed) 			{lab_bed();}
		else if (myState == States.room_225) 			{room_225();}
		else if (myState == States.room_225_monitor) 	{room_225_monitor();}
		else if (myState == States.room_225_desk) 		{room_225_desk();}
		//else if (myState == States.hallway_upstairs) 	{hallway_upstairs();}
		//else if (myState == States.hallway_downstairs){hallway_downstairs();}

	}

	void title ()
	{
		text.text = "Are there times when someone shouldn't be allowed into a hospital?\n" +
					"If it was known that they had a tendency to harm others, would you still let them in?\n\n\n\n" +
					"Press [Space] to check-in";
		if 		(Input.GetKeyDown (KeyCode.Space)) {myState = States.hospital_bed;}
	}

	#region HospitalRoom
	void hospital_bed()
	{
		text.text = "You awake to the rhythmic beeping of what sounds to be a heart monitor resting next to your bed. " +
					"You roll over to check the time on your clock only to jerk awake in fear. This is not your room.\n\n" +
					"The dim light above you flickers as you try to get your bearings. The light colored walls and medical equipment surrounding you places you in a hospital, " +
					"but you were never admitted. At least...you can't remember being admitted. A dark figure watching you through a window slowly drifts away as you glance over at them.\n\n\n" +
					"Press [G] to Get up and look around";
		if 		(Input.GetKeyDown (KeyCode.G)) 	{myState = States.hospital_bed_room;}
	}

	void hospital_bed_room ()
	{
		if (!gotUp) {
			text.text = "You gently pull the IV out of your arm and proceed to lift yourself up and out of your new bedding. As the floor comes into view, you notice bloody footprints " +
			"decorating the tiles. Someone has visited your bedside recently. As your gaze moves up, you begin to take in your unfamiliar surroundings.\n\n" +
			"There is a computer monitor next to the head of your bed with what seems to be patient information on it. Further away from your bed is a desk with papers on " +
			"it nested against the wall. There is also a chair near the desk. Finally, you notice a door clearly leading to the hallway with a large window next to it.\n\n" +
			"Press [M] for Monitor, [D] for Desk, [C] for Chair, [O] for door, or [W] for Window";
		} else {
			text.text = "There is a computer monitor next to the head of your bed with what seems to be patient information on it. Further away from your bed is a desk with papers on " +
			"it nested against the wall. There is also a chair near the desk. Finally, you notice a door clearly leading to the hallway with a large window next to it.\n\n\n" +
			"Press [M] for Monitor, [D] for Desk, [C] for Chair, [O] for door, or [W] for Window";
		}

		if 		(Input.GetKeyDown (KeyCode.M)) 	{myState = States.monitor_0;}
		else if (Input.GetKeyDown (KeyCode.D)) {myState = States.desk_0;}
		else if (Input.GetKeyDown (KeyCode.C)) {myState = States.chair;}
		else if (Input.GetKeyDown (KeyCode.O)) {myState = States.door_0;}
		else if (Input.GetKeyDown (KeyCode.W)) {myState = States.window_0;}
	}

	void desk_0()
	{
		gotUp = true;
		text.text = "The papers on the desk are vandalized with the hospitals large logo centered right at the top. The pages feel crisp and wavy, altered by water damage but still legible. " +
					"They appear to be documentation regarding the admittance and right to " +
					" keep the patient 'DEAN WELLS' until his treatment is complete.\n\nEven though they are written as if the intended party is the legal guardian of DEAN, his own signature is found " +
					"on the bottom of each and every page. He must have signed away his life.\n\n\n" +
					"Press [R] to Return to the room";

		if 		(Input.GetKeyDown (KeyCode.R)) 	{myState = States.hospital_bed_room;}
	}

	void monitor_0()
	{
		gotUp = true;
		text.text = "The monitor displays the name DEAN WELLS listing the cause for admittance as a CAR ACCIDENT. The name Dean feels unknown to you and you try to remember anything " +
					"regarding your name or recent events. A dull pain grows in the back of your skull as you try to focus, but for some reason the only name that comes to mind is Eric.\n\n" +
					"'Is my name Eric?,' you wonder to yourself. A further examination of the screen shows an area where vitals could display and under previous conditions " +
					"DEMENTIA and SCHIZOPHRENIA are listed as if none of DEAN's words to be trusted.\n\n\n" +
					"Press [R] to Return to the room";

		if 		(Input.GetKeyDown (KeyCode.R)) 	{myState = States.hospital_bed_room;}
	}

	void chair()
	{
		gotUp = true;
		text.text = "A blue metal chair sits next to the desk riddled with hospital documents. The padding looks worn and the metal is oddly rusted, but as you go over and pick it up to move " +
					"it around, you realize it is quite sturdy. You could take the chair with you, but you're not quite sure if it would be of any help. Nothing is making sense in this hospital " +
					"and it's affecting your thoughts. 'Why I am considering taking a chair with me?'\n\n\n" +
					"Press [T] to Take the chair or [R] to Return to the room";

		if 		(Input.GetKeyDown (KeyCode.R)) 	{myState = States.hospital_bed_room;}
		else if (Input.GetKeyDown (KeyCode.T)) 	{myState = States.hospital_bed_chair;}
	}

	void door_0()
	{
		gotUp = true;
		text.text = "The wide, wooden door has scratches all along the back of it. At first it appeared that there might be a message carved into it, but you quickly realized that it is all " +
					"just a futile attempt to escape. The dried blood on the door and the red stain on the floor below it are a clear explanation for that.\n\n" +
					"Regardless, you still try your hand at the doorknob out of panic. It doesnt budge in the slightest. While the door gives a bit while pushing and pulling the knob will not turn at all." +
					"After a few more desperate attempts and a brusied shoulder, you come to the conclusion you're stuck.\n\n\n" +
					"Press [R] to Return to the room";

		if 		(Input.GetKeyDown (KeyCode.R)) 	{myState = States.hospital_bed_room;}
	}

	void window_0()
	{
		gotUp = true;
		text.text = "As you gaze through the window you notice the outside hallway is even more dimly lit. A few of the lights that are flickering spend more time off than on. As one of the lights " +
					"flickers on you notice a man at the end of the hallway barely in view watching you. He acknowledges your presence with a show by pulling out a knife and grazing it across " +
					"his hand before turning and walking off.\n\n" +
					"The sight makes your stomach churn but your focus turns to the small crack in the window. It could be broken...\n\n\n" +
					"Press [R] to Return to the room";

		if 		(Input.GetKeyDown (KeyCode.R)) 	{myState = States.hospital_bed_room;}
	}

	void hospital_bed_chair()
	{
		text.text = "While holding the chair, you look around the room.\n\n" +
					"There is a computer monitor next to the head of your bed with what seems to be patient information on it. Further away from your bed is a desk with papers on " +
					"it nested against the wall. Finally, you notice a door clearly leading to the hallway with a large window next to it.\n\n\n" +
					"Press [M] for Monitor, [D] for Desk, [O] for door, or [W] for Window";

		if 		(Input.GetKeyDown (KeyCode.M)) 	{myState = States.monitor_1;}
		else if (Input.GetKeyDown (KeyCode.D)) {myState = States.desk_1;}
		else if (Input.GetKeyDown (KeyCode.O)) {myState = States.door_1;}
		else if (Input.GetKeyDown (KeyCode.W)) {myState = States.window_1;}
	}

	void desk_1 ()
	{
		text.text = "Holding a chair is not going to make the contents of the desk different.\n\n" +
					"The papers on the desk are vandalized with the hospitals large logo centered right at the top. The pages feel crisp and wavy, altered by water damage but still legible. " +
					"They appear to be documentation regarding the admittance and right to " +
					" keep the patient 'DEAN WELLS' until his treatment is complete.\n\nEven though they are written as if the intended party is the legal guardian of DEAN, his own signature is found " +
					"on the bottom of each and every page. He must have signed away his life.\n\n\n" +
					"Press [R] to Return to the room";

		if 		(Input.GetKeyDown (KeyCode.R)) 	{myState = States.hospital_bed_chair;}
	}

	void monitor_1 ()
	{
		text.text = "Holding a chair is not going to change the monitor screen.\n\n" +
					"The monitor displays the name DEAN WELLS listing the cause for admittance as a CAR ACCIDENT. The name Dean feels unknown to you and you try to remember anything " +
					"regarding your name or recent events. A dull pain grows in the back of your skull as you try to focus, but for some reason the only name that comes to mind is Eric.\n\n" +
					"'Is my name Eric?,' you wonder to yourself. A further examination of the screen shows an area where vitals could display and under previous conditions " +
					"DEMENTIA and SCHIZOPHRENIA are listed as if none of DEAN's words to be trusted.\n\n\n" +
					"Press [R] to Return to the room";

		if 		(Input.GetKeyDown (KeyCode.R)) 	{myState = States.hospital_bed_chair;}
	}

	void door_1 ()
	{
		text.text = "You desperately throw the chair at the door trying your hardest to cause some sort of damage, but the door is left unscathed. As you pant and try to catch your breath " +
					"you realize that the door will not break or falter.\n\nThe scratches on the door mock you and laugh in your face. This definitely is not going to work and is only " +
					"making a lot of noise. It is probably in your best interest not to make this much noise.\n\n\n" +
					"Press [R] to Return to the room";

		if 		(Input.GetKeyDown (KeyCode.R)) 	{myState = States.hospital_bed_chair;}
	}

	void window_1 ()
	{
		text.text = "After hitting the window a few times with the legs of the chair, the cracks continue to grow in size. An alarm in the room begins to go off. Despite your best effort you are unable to break it from " +
					"such close range. It probably has to do with the fact that you are afraid of the glass breaking near you. It also doesn't help that your head is throbbing from the noise.\n\n" +
					"There isn't much time before others are drawn to the room. You need to break the window now and climb through. You set up and get ready to throw the chair at the window from a distance.\n\n\n" +
					"Press [T] to Throw the chair through the window";

		if 		(Input.GetKeyDown (KeyCode.T)) 	{myState = States.hallway_middle;}
	}
	#endregion

	#region HallwayMiddle
	void hallway_middle ()
	{
		if (!throughWindow) {
			text.text = "The chair goes flying through the window, shattering the glass all at once. You quickly follow through right after, accidently cutting parts of your hands and legs " +
			"in the process.\n\nA quick glance around the hallway makes it look completely empty, however, it is hard to be sure in the dim lighting. You notice there are three " +
			"doors leading to rooms in the hallway, each with an unsettling stain nearby, and a stairway leading to the upper level and lower level of the hospital. The man " +
			"is nowhere in sight.\n\n\n" +
			"Press [1] to enter Room 223, [2] to enter Room 224, [3] to enter room 225, [U] to head Upstairs or [D] to head Downstairs";
		} else if (throughWindow) {
			text.text = "There are three " +
			"doors leading to rooms in this hallway and a stairway leading to the upper level and lower level of the hospital. The man " +
			"is still nowhere in sight.\n\n\n" +
			"Press [1] to enter Room 223, [2] to enter Room 224, [3] to enter room 225, [U] to head Upstairs or [D] to head Downstairs";
		}

		if 			(Input.GetKeyDown (KeyCode.Alpha1)) {myState = States.room_223;}
		else if 	(Input.GetKeyDown (KeyCode.Alpha2)) {myState = States.room_224;}
		else if 	(Input.GetKeyDown (KeyCode.Alpha3)) {myState = States.room_225;}
		else if 	(Input.GetKeyDown (KeyCode.U)) 		{myState = States.hallway_upstairs;}
		else if 	(Input.GetKeyDown (KeyCode.D)) 		{myState = States.hallway_downstairs;}
	}

	void room_223 ()
	{
		throughWindow = true;

		text.text = "You stand in Room 223 and immediately regret your decision. There is a patient wrapped in bandages sleeping on the bed. At first you questioned whether he is actually sleeping " +
					"or not, however, the constant rhythmic breathing tells you otherwise.\n\nIf you make your visit quick, you might be able to find out some information about the patient " +
					"and maybe this hospital, but you can always just leave and move on.\n\n\n" +
					"Press [M] to view Monitor, [D] to visit the Desk, or [R] to Return to the Hallway";

		if 			(Input.GetKeyDown (KeyCode.M)) {myState = States.room_223_monitor;}
		else if 	(Input.GetKeyDown (KeyCode.D)) {myState = States.room_223_desk;}
		else if 	(Input.GetKeyDown (KeyCode.R)) {myState = States.hallway_middle;}
	}

	void room_223_monitor() 
	{
		text.text = "The monitor displays the name JESSICA WILLIAMS across the top. You had no idea that it was a girl, but it is not like anyone could have figured that out just by looking at her " +
					"bandages. Her vitals are displayed and active but nothing appears to be off. She seems perfectly healthy.\n\nThen you look at her previous condidtions and once again " +
					"two mental illnesses are listed: DEMENTIA and SCHIZOPHRENIA. It is highly unlikely that this is the case but what do you know. You can't even remember who you are " +
					"let alone be able to distinguish when a medical file is incorrect.\n\n\n" +
					"Press [R] to Return to the room";

		if 			(Input.GetKeyDown (KeyCode.R)) {myState = States.room_223;}
	}

	void room_223_desk ()
	{
		text.text = "On the desk are the same papers found in the room you woke up in. Once again it seems like Jessica also signed herself away into the hospital. You aren't sure this makes " +
					"sense because the sheets are written as if someone else should be signing them in place of Jessica. 'Are people brought here by force', you wonder to yourself.\n\n" +
					"After skimming through the paper you see BURNED IN A CAR ACCIDENT. A sudden feeling of dread fills you, and you put the paper down avoiding going any deeper and pressing your luck in the room.\n\n\n" +
					"Press [R] to Return to the room";

		if 			(Input.GetKeyDown (KeyCode.R)) {myState = States.room_223;}
	}

	void room_224 ()
	{
		if (!hasHook) {
			throughWindow = true;
			text.text = "You are in Room 224. It is eerily similar to the room that you woke up in, but much cleaner. You see an empty hospital bed whose sheets look recently changed, an empty desk, and a monitor. " +
						"As your gaze moves to the floor, you can't help but notice the way the dim light gleams across a freshly mopped floor. Something is not quite right\n\n." +
						"While continuing to look around the room you notice a section of the wall that almost appears to have a slight crack in it with light shining through.\n\n\n" +
						"Press [D] to view the Desk, [M] to examine the Monitor, [W] to approach the crack, or [R] to return to the hallway";

			if 			(Input.GetKeyDown (KeyCode.D)) {myState = States.room_224_desk;}
			else if 	(Input.GetKeyDown (KeyCode.M)) {myState = States.room_224_monitor;}
			else if 	(Input.GetKeyDown (KeyCode.W)) {myState = States.dry_wall_entrance;}
			else if 	(Input.GetKeyDown (KeyCode.R)) {myState = States.hallway_middle;}
		} else {
			text.text = "You are in Room 224. It is eerily similar to the room that you woke up in, but much cleaner. You see an empty hospital bed whose sheets look recently changed, an empty desk, and a monitor. " +
						"As your gaze moves to the floor, you can't help but notice the way the dim light gleams across a freshly mopped floor. Something is not quite right\n\n\n." +
						"Press [D] to view the Desk, [M] to examine the Monitor, or [R] to return to the hallway";

			if 			(Input.GetKeyDown (KeyCode.Alpha1)) {myState = States.room_223;}
			else if 	(Input.GetKeyDown (KeyCode.Alpha2)) {myState = States.room_224;}
		}
	}

	void room_224_desk ()
	{
		text.text = "The desk has been wiped clean of any papers that may have been there before. The wood looks ancient and rough, but there are clear spots of red showing through a recent " +
		"stain job. You try to open the drawers, but only find pens lying around. There isn't anything too interesting.\n\n\n" +
		"Press [R] to return to the room";

		if 			(Input.GetKeyDown (KeyCode.R)) {myState = States.room_224;}
	}

	void room_224_monitor () 
	{
		text.text = "The monitor displays the name DARIUS LEMAIRE across the top. Below where his vitals and medical information should be showing, a large black banner with red text covers " +
					"the entire section. The banner reads SURGERY IN PROCESS and the text fades in and out. You highly doubt that an empty hospital like this would have surgeries going on, " +
					"and so your focus drifts away from the monitor to a slow, rhythmic beeping coming from one of the rooms walls.\n\n\n" +
					"Press [R] to Return to the room";

		if 			(Input.GetKeyDown (KeyCode.R)) {myState = States.room_224;}
	}

	void dry_wall_entrance ()
	{
		text.text = "As you approach the wall, a slow, rhythmic electronic beeping begins to grow louder and louder. You put your eye up against the crack and gaze through into the other room. " +
					"The floor is made up of white tiles stained from the blood of patients being operated on. The air coming through feels colder than normal. There is a metal operating table in the center " +
					"of the room where a patient lies. His chest moves up and down heavily with every breath he takes yet his eyes never open. No one else appears to be in the room.\n\n" +
					"The wall appears thin and breakable.\n\n\n" +
					"Press [D] to Destroy the wall and enter the operating room or [R] to Return to room 224";

		if 			(Input.GetKeyDown (KeyCode.R)) {myState = States.room_224;}
		else if 	(Input.GetKeyDown (KeyCode.D)) {myState = States.lab;}
	}

	void lab ()
	{
		if (!hasHook) {
			text.text = "" +
						"";


			if 			(Input.GetKeyDown (KeyCode.M)) {myState = States.lab_monitor;}
			else if 	(Input.GetKeyDown (KeyCode.B)) {myState = States.lab_bed;}
		} else {
			text.text = "" +
						"";


			if 			(Input.GetKeyDown (KeyCode.M)) {myState = States.lab_monitor;}
			else if 	(Input.GetKeyDown (KeyCode.B)) {myState = States.lab_bed;}
			else if 	(Input.GetKeyDown (KeyCode.R)) {myState = States.room_224;}
		}
	}

	void lab_bed ()
	{

	}

	void lab_monitor () 
	{

	}

	void room_225 ()
	{
		throughWindow = true;
		text.text = "You are in Room 225. Although there is no patient in the room, everything else appears the same as the room you woke up in. There is a desk with papers sprawled across it and a monitor displaying the " +
					"patient's information. You begin to feel something unsettling about this room in particular. There is almost no sound here. It is almost as if the room itself is sound proof.\n\n" +
					"Your gaze continues to be drawn to the computer monitor near the bed. It flickers in the distance." +
					"Press [D] to view the Desk, [M] to examine the Monitor, or [R] to Return to the hallway";

		if 			(Input.GetKeyDown (KeyCode.R)) {myState = States.hallway_middle;}
		else if 	(Input.GetKeyDown (KeyCode.D)) {myState = States.room_225_desk;}
		else if 	(Input.GetKeyDown (KeyCode.M)) {myState = States.room_225_monitor;}
	}

	void room_225_desk ()
	{
		text.text = "As you approach the desk you notice what looks to be blood soaked into each page. The same message is written on each and every one of them.\n" +
					"\"Curiosity killed the cat, Dean\"\n" +
					"The writing on the page is no longer legible but the trace of a signature is still there. As you hold the page up closer to your face you hear a click. " +
					"You look up towards the noise and notice a camera watching you in the corner of the room. You immediately drop the papers and step back.\n\n\n" +
					"Press [R] to Return to the room";

		if 			(Input.GetKeyDown (KeyCode.R)) {myState = States.room_225;}
	}

	void room_225_monitor ()
	{

		text.text = "The monitor displays the name TIM ZHOU across the top. Although the medical equipment is clearly disconnected and laying on the floor, the monitor continues to " +
					"eerily display Tim's heartbeat in real time. As you examine the screen closer, noticing DEMENTIA and SCHIZOPHRENIA listed under the section labeled mental illnesses, " +
					"Tim's pulse begins to rise and the machine beeps louder and louder. You back away, frantically checking around the room in a panic.\n\n\n" +
					"Press [R] to Return to the room";

		if 			(Input.GetKeyDown (KeyCode.R)) {myState = States.room_225;}
	}

	#endregion
}
