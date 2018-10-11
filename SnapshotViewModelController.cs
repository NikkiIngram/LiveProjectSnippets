using System;

//calculated avg job placement days by location on SnapshotViewModelController

public class SnapshotViewModelControllerChanges
{
    public SnapshotViewModelControllerChanges()
    {
        int totalDaysInJP = 0, portlandDaysInJP = 0, denverDaysInJP = 0, seattleDaysInJP = 0, remoteDaysInJP = 0;
        int totalStudents = 0, portlandStudents = 0, denverStudents = 0, seattleStudents = 0, remoteStudents = 0;
        int avgDaysInJP = 0, portlandAvgDaysInJP = 0, denverAvgDaysInJP = 0, seattleAvgDaysInJP = 0, remoteAvgDaysInJP = 0;

        foreach (var student in db.JPStudents)
        {
            int id = student.JPStudentId;

            if (student.JPHired == true)
            {
                if ((student.JPStudentLocation == JPStudentLocation.PortlandLocal) || (student.JPStudentLocation == JPStudentLocation.PortlandRemote))
                {
                    portlandDaysInJP += (int)(DateTime.Now - student.JPStartDate).TotalDays;
                    portlandStudents++;
                }
                if ((student.JPStudentLocation == JPStudentLocation.DenverLocal) || (student.JPStudentLocation == JPStudentLocation.DenverRemote))
                {
                    denverDaysInJP += (int)(DateTime.Now - student.JPStartDate).TotalDays;
                    denverStudents++;
                }
                if ((student.JPStudentLocation == JPStudentLocation.SeattleLocal) || (student.JPStudentLocation == JPStudentLocation.SeattleRemote))
                {
                    seattleDaysInJP += (int)(DateTime.Now - student.JPStartDate).TotalDays;
                    seattleStudents++;
                }
                if ((student.JPStudentLocation == JPStudentLocation.Remote))
                {
                    remoteDaysInJP += (int)(DateTime.Now - student.JPStartDate).TotalDays;
                    remoteStudents++;
                }
                totalDaysInJP += (int)(DateTime.Now - student.JPStartDate).TotalDays;
                totalStudents++;
            }
        }

        if (portlandStudents > 0) { portlandAvgDaysInJP = (portlandDaysInJP / portlandStudents); }
        if (denverStudents > 0) { denverAvgDaysInJP = (denverDaysInJP / denverStudents); }
        if (seattleStudents > 0) { seattleAvgDaysInJP = (seattleDaysInJP / seattleStudents); }
        if (remoteStudents > 0) { remoteAvgDaysInJP = (remoteDaysInJP / remoteStudents); }
        avgDaysInJP = (totalDaysInJP / totalStudents);

        var snapshotStats = new SnapshotViewModel(newJpStudentsList, weeklyHiresList, totalWeeklyApps, totalWeeklyHires, jpStudentCount, unhiredGradCount,
            newJpStudentsList_Portland, weeklyHiresList_Portland, totalWeeklyApps_Portland, totalWeeklyHires_Portland, jpStudentCount_Portland, unhiredGradCount_Portland,
            newJpStudentsList_Denver, weeklyHiresList_Denver, totalWeeklyApps_Denver, totalWeeklyHires_Denver, jpStudentCount_Denver, unhiredGradCount_Denver,
            newJpStudentsList_Seattle, weeklyHiresList_Seattle, totalWeeklyApps_Seattle, totalWeeklyHires_Seattle, jpStudentCount_Seattle, unhiredGradCount_Seattle,
            newJpStudentsList_Remote, weeklyHiresList_Remote, totalWeeklyApps_Remote, totalWeeklyHires_Remote, jpStudentCount_Remote, unhiredGradCount_Remote,
            avgDaysInJP, portlandAvgDaysInJP, denverAvgDaysInJP, seattleAvgDaysInJP, remoteAvgDaysInJP, totalDaysInJP, portlandDaysInJP, denverDaysInJP, seattleDaysInJP, remoteDaysInJP
            );

    }
}
