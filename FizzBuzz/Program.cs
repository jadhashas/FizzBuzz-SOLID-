// See https://aka.ms/new-console-template for more information

using FizzBuzz.Services;

var processor = new FizzBuzzProcessor();
var compute = new Compute(processor);
compute.AfficherFizzBuzz();