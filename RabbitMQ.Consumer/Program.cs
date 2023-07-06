﻿using RabbitMQ.Client;
using RabbitMQ.Consumer;

var factory = new ConnectionFactory
{
    Uri = new Uri("amqp://guest:guest@localhost:5672")
};

using var connection = factory.CreateConnection();
using var channel = connection.CreateModel();

DirectExchangeConsumer.Consume(channel);