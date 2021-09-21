create database rockoverflow;
use rockoverflow;

create table questions (
	id int not null AUTO_INCREMENT,
    username varchar(20) not null,
    title varchar(200) not null,
    detail varchar(2000),
    posted datetime,
    category varchar(20),
    tags varchar(50),
    currentstatus int,
    primary key(id)
);
create table answers(
	id int not null auto_increment,
    username varchar(20) not null,
    detail varchar(200),
    questionId int,
    posted datetime,
    upvotes int,
    PRIMARY KEY (id),
    foreign key (questionId) references questions(id)
);
insert into questions(username, title, detail, category, tags, currentstatus) values 
	('RyanCo', 'Shortcut for Console WriteLine', 'What is the schortcut for doing a Console.WriteLine?','c#','shortcuts','1');
insert into questions(username, title, detail, category, tags, currentstatus) values 
	('ZeroCool', 'Hacks', 'How do you hack a Gibson?','hacks','leet','1');
insert into answers(username, detail, questionId, upvotes) values ('AcidBurn', 'You Can''t', 2, 1);
insert into answers(username, detail, questionId, upvotes) values ('Cereal', 'Oh wow, we are fried!!', 2, 2);
