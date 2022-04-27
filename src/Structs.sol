// SPDX-License-Identifier: MIT
pragma solidity ^0.8.13;

contract Structs {
    struct Car {
        string model;
        uint year;
        address owner;
    }

    Car public car;
    Car[] public cars;
    mapping(address => Car[]) public carsByOwner;

    function examples() external {
        Car memory toyota = Car("toyota", 1990, msg.sender); 
        Car memory lambo = Car({model: "lamborghini", year: 1980, owner: msg.sender});
        Car memory tesla;
        tesla.model = "tesla";
        tesla.year = 2020;
        tesla.owner = msg.sender;

        cars.push(toyota);
        cars.push(tesla);
        cars.push(lambo);

        cars.push(Car({model: "ferrari", year: 1991 ,owner: msg.sender}));
        
        Car storage _car = cars[0];
        _car.year = 1999;
        delete _car.owner;
    }
}