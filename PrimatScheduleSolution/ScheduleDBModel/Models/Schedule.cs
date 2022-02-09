﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;

namespace DataBaseExploitation.Models
{
    public class Schedule
    {
        public List<Lesson> Lessons { get; private set; }

        public Schedule() => Lessons = new List<Lesson>();

        public void AddPair(Lesson newPair)
        {
            try
            {
                Lesson pair = Lessons.First(pair => pair.LessonNumber == newPair.LessonNumber && pair.Fraction == newPair.Fraction);
                pair.Professor.Add(newPair.Professor.First());
            }
            catch
            {
                Lessons.Add(newPair);
            }
        }

        public override string ToString()
        {
            string result = String.Empty;

            try
            {
                CultureInfo culture = CultureInfo.CurrentCulture;

                foreach (var lesson in Lessons)
                {
                    result += $"{lesson.Description}\n[{lesson.Subject}]({lesson.Link})\n{String.Join(", ", lesson.Professor)}\n" +
                            $"{DateTime.Parse(lesson.StartTime, culture).ToString("HH:mm", culture)}-" +
                            $"{DateTime.Parse(lesson.EndTime, culture).ToString("HH:mm", culture)}\n{lesson.Type}\n" +
                            (String.IsNullOrEmpty(lesson.Fraction) ? String.Empty : $"{lesson.Fraction}\n");
                }
            }
            catch
            {
                result = $"{Lessons.First().Description}";
            }

            return result;
        }
    }
}
