using System;

public class Song
{
    private string artistName;
    private string songName;
    private int songMinutes;
    private int songSeconds;

    public Song(string artistName, string songName, int songMinutes, int songSeconds)
    {
        this.ArtistName = artistName;
        this.SongName = songName;
        this.SongMinutes = songMinutes;
        this.SongSeconds = songSeconds;
    }

    public string ArtistName
    {
        get => this.artistName;
        protected set
        {
            if (value.Length < 3 || value.Length > 20)
            {
                throw new ArgumentException("Artist name should be between 3 and 20 symbols.");
            }
            this.artistName = value;
        }
    }

    public string SongName
    {
        get => this.songName;
        protected set
        {
            if (value.Length < 3 || value.Length > 30)
            {
                throw new ArgumentException("Song name should be between 3 and 30 symbols.");
            }
            this.songName = value;
        }
    }

    public int SongMinutes
    {
        get => this.songMinutes;
        protected set
        {
            if (value < 0 || value > 14)
            {
                throw new ArgumentException("Song minutes should be between 0 and 14.");
            }
            this.songMinutes = value;
        }
    }

    public int SongSeconds
    {
        get => this.songSeconds;
        protected set
        {
            if (value < 0 || value > 59)
            {
                throw new ArgumentException("Song seconds should be between 0 and 59.");
            }
            this.songSeconds = value;
        }
    }

    public int CalculateSongLength()
    {
        return this.SongMinutes * 60 + this.SongSeconds;
    }
}

