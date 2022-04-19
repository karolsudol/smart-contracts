// SPDX-License-Identifier: UNLICENSED
pragma solidity ^0.8.10;

contract Counter {
    
    // state var
    uint public count;

    // Function to get current count
    function get() public view returns (uint) {
        return count;
    }

    // Function to increment count by 1
    // write , not read func
    function inc() external {
        count += 1;
    }

    // Function to decrement count by 1
    function dec() external {
        count -= 1;
    }

    // Function to increment count by a number
    function incByNum(uint num) public {
        count += num;
    }

    // Function to decrement count by a number
    function decByNum(uint num) public {
        count -= num;
    }
}
