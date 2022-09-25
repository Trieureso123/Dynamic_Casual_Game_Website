
use GameWebsiteDb

create table Account ( IdAccount int primary key identity(1,1),
						NameAccount nvarchar(100),
						Username nvarchar(100),
						Password nvarchar(100)
					)

create table Question ( IdQuestion int primary key identity(1,1),
						Question nvarchar(500),
						PhoneNumber nvarchar(15),
						Email nvarchar(100)
						)

create table Category ( IdCategory int primary key identity(1,1),
						NameCategory nvarchar(20)
						)


create table Lesson ( IdLesson int primary key identity(1,1),
					  IdCategory int foreign key references Category(IdCategory),
					  NameLesson nvarchar(100),
					  VideoUrl nvarchar(300))

create table Description (IdDescription int primary key identity(1,1),
						  IdLesson int foreign key references Lesson(IdLesson),
						  Time nvarchar(20),
						  Description nvarchar(500))

create table Feedback ( IdFeedback int primary key identity(1,1),
						IdLesson int foreign key references Lesson(IdLesson),
						LessonFeedback nvarchar(500),
						PhoneNumber nvarchar(15),
						Rating int)

drop table Feedback

select * from Account
select * from Question
select * from Category
select * from Description
select * from Feedback
select * from Lesson


insert into Account values ('admin', 'admin', 'admin')
insert into Category values ('2DProgramming')
insert into Lesson values(1,'Basic programming with C#', 'https://www.youtube.com/watch?v=gB1F9G0JXOo&ab_channel=freeCodeCamp.org')



insert into Description values (1, '9:07','Introducing to Unity interface')
insert into Description values (1, '22:10','Starting with Unity basic')
insert into Description values (1, '29:47','RigidBodies and CollidersS')
insert into Description values (1, '38:19','Audio Source and UI Elements')
insert into Description values (1, '45:47','Moving character with code')
insert into Description values (1, '54:22','Introducing to Variables')
insert into Description values (1, '1:06:14','Operations with Variables')
insert into Description values (1, '1:19:01','Functions')
insert into Description values (1, '1:34:22','Conditional Statements')
insert into Description values (1, '1:49:29','Loops')
insert into Description values (1, '1:58:41','Coroutines')
insert into Description values (1, '2:04:39','Classes')
insert into Description values (1, '2:16:39','Accessibility Modifiers (Data Encapsulation)')
insert into Description values (1, '2:26:54', 'Inheritance')

insert into Description values (1, '2:43:35', 'Getting Components')
insert into Description values (1, '2:52:32', 'Monster chase game intro')
insert into Description values (1, '2:53:55', 'Importing Assets')
insert into Description values (1, '3:02:22', 'Creating player animations')
insert into Description values (1, '3:17:36', 'Sorting layers and Order in layer')
insert into Description values (1, '3:24:04', 'Creating the game background')
insert into Description values (1, '3:33:03', 'Player Movement')
insert into Description values (1, '3:50:26', 'Animating the player via code')
insert into Description values (1, '4:04:34', 'Player jumping')
insert into Description values (1, '4:19:03', 'Camera follow player')
insert into Description values (1, '4:30:42', 'Enemy animations')

insert into Description values (1, '4:39:40', 'Enemy script')
insert into Description values (1, '4:51:15', 'Enemy Spawner')
insert into Description values (1, '5:15:15', 'Enemy Collision')
insert into Description values (1, '5:31:55', 'The collector script')
insert into Description values (1, '5:40:32', 'UI System in Unity')
insert into Description values (1, '5:53:06', 'Creating main menu')
insert into Description values (1, '6:02:34', 'Navigating between scenes')
insert into Description values (1, '6:13:04', 'Selecting a character')
insert into Description values (1, '6:20:50', 'Static variables')
insert into Description values (1, '6:30:23', 'Singleton Pattern')
insert into Description values (1, '6:41:35', 'Events And Delegates')
insert into Description values (1, '7:13:11', 'Instantiating the selected character')
insert into Description values (1, '7:17:59', 'Finish the game')


insert into Question values ('why the unity can make game?', '0712596230', 'lac@gmail.com')
insert into Feedback values (1, 'i have nothing to say hihi', '236034347', 2)


