using System;
using System.Collections.Generic;

// Interface Observer
public interface IObserver
{
    void Update(string message);
}

// Interface Subject
public interface ISubject
{
    void Attach(IObserver observer);
    void Detach(IObserver observer);
    void Notify();
}

// Concrete Subject
public class NewsAgency : ISubject
{
    private List<IObserver> observers = new List<IObserver>();
    private string news;

    public void SetNews(string news)
    {
        this.news = news;
        Notify();
    }

    public void Attach(IObserver observer) => observers.Add(observer);
    public void Detach(IObserver observer) => observers.Remove(observer);
    public void Notify()
    {
        foreach (var observer in observers)
            observer.Update(news);
    }
}

// Concrete Observer
public class Subscriber : IObserver
{
    private string name;

    public Subscriber(string name) => this.name = name;

    public void Update(string message)
    {
        Console.WriteLine($"[NOTIFIKASI UNTUK {name}]: {message}");
    }
}

// Main Program
public class Program
{
    public static void Main(string[] args)
    {
        NewsAgency agency = new NewsAgency();

        Subscriber alice = new Subscriber("Alice");
        Subscriber bob = new Subscriber("Bob");

        agency.Attach(alice);
        agency.Attach(bob);

        agency.SetNews("Berita Baru: Cuaca Hari Ini Cerah!");
        agency.Detach(alice);
        agency.SetNews("Berita Terbaru: Hujan Deras Sore Ini!");
    }
}
