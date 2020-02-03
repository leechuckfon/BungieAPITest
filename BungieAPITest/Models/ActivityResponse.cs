using System;
using System.Collections.Generic;
using System.Text;

namespace BungieAPITest.Models {
    public class ActivityDetails {
        public object referenceId { get; set; }
        public object directorActivityHash { get; set; }
        public string instanceId { get; set; }
        public int mode { get; set; }
        public List<int> modes { get; set; }
        public bool isPrivate { get; set; }
        public int membershipType { get; set; }
    }

    public class Basic {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class Assists {
        public string statId { get; set; }
        public Basic basic { get; set; }
    }

    public class Basic2 {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class Completed {
        public string statId { get; set; }
        public Basic2 basic { get; set; }
    }

    public class Basic3 {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class Deaths {
        public string statId { get; set; }
        public Basic3 basic { get; set; }
    }

    public class Basic4 {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class Kills {
        public string statId { get; set; }
        public Basic4 basic { get; set; }
    }

    public class Basic5 {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class OpponentsDefeated {
        public string statId { get; set; }
        public Basic5 basic { get; set; }
    }

    public class Basic6 {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class Efficiency {
        public string statId { get; set; }
        public Basic6 basic { get; set; }
    }

    public class Basic7 {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class KillsDeathsRatio {
        public string statId { get; set; }
        public Basic7 basic { get; set; }
    }

    public class Basic8 {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class KillsDeathsAssists {
        public string statId { get; set; }
        public Basic8 basic { get; set; }
    }

    public class Basic9 {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class Score {
        public string statId { get; set; }
        public Basic9 basic { get; set; }
    }

    public class Basic10 {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class ActivityDurationSeconds {
        public string statId { get; set; }
        public Basic10 basic { get; set; }
    }

    public class Basic11 {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class Team {
        public string statId { get; set; }
        public Basic11 basic { get; set; }
    }

    public class Basic12 {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class CompletionReason {
        public string statId { get; set; }
        public Basic12 basic { get; set; }
    }

    public class Basic13 {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class FireteamId {
        public string statId { get; set; }
        public Basic13 basic { get; set; }
    }

    public class Basic14 {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class StartSeconds {
        public string statId { get; set; }
        public Basic14 basic { get; set; }
    }

    public class Basic15 {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class TimePlayedSeconds {
        public string statId { get; set; }
        public Basic15 basic { get; set; }
    }

    public class Basic16 {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class PlayerCount {
        public string statId { get; set; }
        public Basic16 basic { get; set; }
    }

    public class Basic17 {
        public double value { get; set; }
        public string displayValue { get; set; }
    }

    public class TeamScore {
        public string statId { get; set; }
        public Basic17 basic { get; set; }
    }

    public class Values {
        public Assists assists { get; set; }
        public Completed completed { get; set; }
        public Deaths deaths { get; set; }
        public Kills kills { get; set; }
        public OpponentsDefeated opponentsDefeated { get; set; }
        public Efficiency efficiency { get; set; }
        public KillsDeathsRatio killsDeathsRatio { get; set; }
        public KillsDeathsAssists killsDeathsAssists { get; set; }
        public Score score { get; set; }
        public ActivityDurationSeconds activityDurationSeconds { get; set; }
        public Team team { get; set; }
        public CompletionReason completionReason { get; set; }
        public FireteamId fireteamId { get; set; }
        public StartSeconds startSeconds { get; set; }
        public TimePlayedSeconds timePlayedSeconds { get; set; }
        public PlayerCount playerCount { get; set; }
        public TeamScore teamScore { get; set; }
    }

    public class Activity {
        public DateTime period { get; set; }
        public ActivityDetails activityDetails { get; set; }
        public Values values { get; set; }
    }

    public class ActivityResponseResponse {
        public List<Activity> activities { get; set; }
    }

    public class ActivityResponseMessageData {
    }

    public class ActivityResponse {
        public ActivityResponseResponse Response { get; set; }
        public int ErrorCode { get; set; }
        public int ThrottleSeconds { get; set; }
        public string ErrorStatus { get; set; }
        public string Message { get; set; }
        public MessageData MessageData { get; set; }
    }
}
