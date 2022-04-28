// SPDX-License-Identifier: UNLICENSED
pragma solidity ^0.8.13;

contract Contract {
    uint256 public number;

    function setNumber(uint256 _number) public {
        number = _number;
    }

    function get() public view returns (uint) {
        return number;
    }
    
}