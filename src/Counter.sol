// SPDX-License-Identifier: UNLICENSED
pragma solidity ^0.8.10;

contract Counter {
    
    // state var
    uint public count;
    bool public paused;

    function setPause(bool _paused) external {
        paused = _paused;
    }

    // Function to get current count
    function get() public view returns (uint) {
        return count;
    }


    error pauseError(string msg);

    modifier whenNotPaused() {
        require(!paused, "puased");
        _;
    }

    modifier cap(uint _x) {
        require(_x < 100, "x >= 100");
        _;

    }


    // Function to increment count by 1
    // write , not read func
    function inc() external whenNotPaused {
        require(!paused, "puased");
        count += 1;
    }

    // Function to decrement count by 1
    function dec() external whenNotPaused {
        count -= 1;
    }

    // Function to increment count by a number
    function incByNum(uint _num) public whenNotPaused cap (_num) {
        count += _num;
    }

    // Function to decrement count by a number
    function decByNum(uint _num) public whenNotPaused cap (_num)  {
        count -= _num;
    }
}
