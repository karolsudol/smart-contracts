// SPDX-License-Identifier: MIT
pragma solidity ^0.8.12;

contract TimeLock {
    mapping (address=>uint) public balances;
    mapping (address=>uint) public lockTime;

    function deposit() external payable {
        balances[msg.sender] += msg.value;
        lockTime[msg.sender] += block.timestamp + 1 weeks;
    }

    function increaseLockTime(uint _secondsToIncrease) public {
        lockTime[msg.sender] += _secondsToIncrease;
    }

    function withdraw()public view {
        require(balances[msg.sender] > 0, "Insufficient funds");
        require(block.timestamp > lockTime[msg.sender], "Lock time has not expired");
    }

    
    
}