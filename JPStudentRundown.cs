using System;

//updated JPStudentRundown parameters

public class JPStudentRundownChanges
{
    //public JPStudentRundown(string name, string email, string loc, int daycount, string linkedin, string port, int totalApplications, int totalApplicationsThisWeek, int jpid, bool jpGraduated, int calculateLastContactDate, int checkListStatus)
        public JPStudentRundown(JPStudent student, int totalApplications, int totalApplicationsThisWeek, int calculateLastContactDate, int checkListStatus)
    {
        StudentName = name;
        StudentEmail = email;
        StudentLocation = loc;
        StudentDayCount = daycount;
        StudentLinkedIn = linkedin;
        StudentPortfolio = port;
        StudentName = student.JPName;
        StudentEmail = student.JPEmail;
        StudentLocation = student.JPStudentLocation.ToString();
        StudentDayCount = student.DaysSinceStart;
        StudentLinkedIn = student.JPLinkedIn;
        StudentPortfolio = student.JPPortfolio;
        TotalApplications = totalApplications;
        TotalApplicationsThisWeek = totalApplicationsThisWeek;
        JPStudentId = jpid;
        JPGraduated = jpGraduated;
        JPStudentId = student.JPStudentId;
        JPGraduated = student.JPGraduated;
        CalculateLastContactDate = calculateLastContactDate;
        CheckListStatus = checkListStatus;
    }
    //public JPStudentRundown(string name, string email, string loc, int daycount, string linkedin, string port, int jpid)
     public JPStudentRundown(JPStudent student)
    {
        StudentName = name;
        StudentEmail = email;
        StudentLocation = loc;
        StudentDayCount = daycount;
        StudentLinkedIn = linkedin;
        StudentPortfolio = port;
        JPStudentId = jpid;
        StudentName = student.JPName;
        StudentEmail = student.JPEmail;
        StudentLocation = student.JPStudentLocation.ToString();
        StudentDayCount = student.DaysSinceStart;
        StudentLinkedIn = student.JPLinkedIn;
        StudentPortfolio = student.JPPortfolio;
        JPStudentId = student.JPStudentId;
    }
}
