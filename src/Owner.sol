// SPDX-License-Identifier: UNLICENSED
pragma solidity ^0.8.12;

contract Owner {
    address public owner;

    constructor () {
        owner = msg.sender;
    }

    error notOwnerErr();

    modifier onlyOwner() {
        require(msg.sender == owner, "not owner" );
        _;
    }

    function setOwner(address _newOwner) external onlyOwner {
        require(_newOwner != address(0), "invalid address");
        owner = _newOwner;
    }

    function onlyOwnerFunc() external onlyOwner {
        // code
    }

    function anySenderFunc() external {
        // code
    }


    
}