using RecruitmentApp;
using System;

Console.WriteLine("Отдел кадров приветствует вас!");

String RecordType1 = "Vacancy";
String RecordType2 = "Record";
String Name1 = "SoftwareEngineer0001";
String Name2 = "FrontEndEngineer0020";
Record softwareEngineerVacancy = new Record(RecordType1,Name1);
Record frontEndEngineerVacancy = new Record(RecordType1,Name2);
Record softwareEngineerRecord = new Record(RecordType2,Name1);
Record frontEndEngineerRecord = new Record(RecordType2,Name2);

Service recruiter = new Service();
recruiter.SubmitForApproval(softwareEngineerVacancy);
recruiter.Approve(softwareEngineerRecord);
recruiter.SubmitForApproval(frontEndEngineerVacancy);
recruiter.Reject(frontEndEngineerRecord);



/**
* TODO: Разработать сервис и вызвать действия так как указано:
*/

// Вызвать действие "Submit For Approval" для softwareEngineerVacancy
// Вызвать действие "Approve" для softwareEngineerVacancy

// Вызвать действие "Submit For Approval" для frontEndEngineerVacancy
// Вызвать действие "Reject" для frontEndEngineerVacancy


//TODO: Разработать сервис
public class Service
{
       
     public void SubmitForApproval(Record record)
    {
        var Service = new Service();
        Console.WriteLine($"Отправлено на рассмотрение: {record.id} | {record.type}");

    }
    public void Reject(Record record)
    {
        var Service = new Service();
        Console.WriteLine($"Отказ: {record.id} | {record.type}");


    }
    public void Approve(Record record)
    {
        var Service = new Service();
        Console.WriteLine($"Утверждено: {record.id} | {record.type}");

    }
}

