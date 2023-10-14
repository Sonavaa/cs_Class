//Task:
//Student classi yaradirsiz.Name, Surname, Group, Point, isGraduated
//(mezun olub olmadigi ile bagli boolean bir type olacaq) field-leri olacaq.
//Student classindan instance alindigi zaman birbasha student field-lerinin 
//deyerleri dinamik sekilde teyin olunsun.
//Studentin Ad ve soyadini geriye qaytaran bir method yazirsiz.
//Studentin butun deyerlerini geriye qaytaran bir method yazirsiz. 
//Eger mezun olubsa butun deyerlerden sonra bu telebe mezun olub deye yazilsin,
//eger mezun olmayibsa mezun olmadigi ile bagli bir melumat yazilsin
//Studentin balini artirmaq ucun novbeti imtahana girib gire bilmeyeceyi ile
//bagli bir melumat geriye qaytaran method yazirsiz. Bali 80-den yuxari 
//telebeler ikinci imtahana gire biler, asagi olan telebeler ise gire bilmezler.

Student student = new Student("Sona","Abbasova","P237",100,false);

student.ShowFullName();
student.ShowFullInfo();
student.SecondChance();