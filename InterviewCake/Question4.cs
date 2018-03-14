using System;
using System.Collections.Generic;
using System.Linq;

namespace InterviewCake
{
    public class Question4
    {
        public static List<Meeting> mergeRanges(List<Meeting> meetings)
        {
            var sortedMeetings = meetings.Select(m => new Meeting(m.StartTime, m.EndTime))
                .OrderBy(m => m.StartTime).ToList();

            var mergedMeetings = new List<Meeting> { sortedMeetings[0] };
            // Merge meeting ranges
            foreach (var currentMeeting in sortedMeetings)
            {
                var lastMergedMeeting = mergedMeetings.Last();

                if (currentMeeting.StartTime <= lastMergedMeeting.EndTime)
                {
                    lastMergedMeeting.EndTime = Math.Max(lastMergedMeeting.EndTime, currentMeeting.EndTime);
                }
                else
                {
                    mergedMeetings.Add(currentMeeting);
                }
            }

            return mergedMeetings;
        }
    }

    public class Meeting
    {
        public int StartTime { get; set; }

        public int EndTime { get; set; }

        public Meeting(int startTime, int endTime)
        {
            // Number of 30 min blocks past 9:00 am
            StartTime = startTime;
            EndTime = endTime;
        }

        public override string ToString()
        {
            return $"({StartTime}, {EndTime})";
        }
    }
}
