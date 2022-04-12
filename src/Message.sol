// SPDX-License-Identifier: MIT
pragma solidity ^0.8.10;

// contract set the message and then it displays it
contract Message {
    // state variables
    string public message;
    uint256 public lastUpdated = 0;
    address public owner;

    constructor(){
        message = "Hello";
        owner = msg.sender;       
    }

    function setMessage(string calldata _message) public payable {
        if (msg.value < 1 ether) {
            require(msg.sender == owner);
        }
        require(lastUpdated == 0 || block.timestamp >= lastUpdated + 1 days);
        lastUpdated = block.timestamp;
        message = _message;
    }


}