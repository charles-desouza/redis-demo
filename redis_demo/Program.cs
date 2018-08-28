using StackExchange.Redis;
using System;

namespace redis_demo
{
  class Program
  {
    public static void Main(string[] args)
    {
      using(ConnectionMultiplexer redis = ConnectionMultiplexer.Connect("192.168.99.100:6379"))
      {
        IDatabase db = redis.GetDatabase();
        string value = db.StringGet("name");
        Console.WriteLine(value); 
      }

    }
  }
}
