// SPDX-License-Identifier: MIT
pragma solidity ^0.8.12;

contract Vars {
    uint public i;
    bool public b;
    address public myAddress;

    function setStateVars() external {
        i = 123;
        b = true;
        myAddress = address(1);
    }

    function setGlobalVars() external view returns(address, uint, uint) {
        address sender = msg.sender;
        uint ts = block.timestamp;
        uint blockNo = block.number;
        return(sender, ts, blockNo);
    }






}
