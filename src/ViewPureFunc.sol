// SPDX-License-Identifier: MIT

pragma solidity ^0.8.12;

contract ViewPureFunc {
    uint public num;
    function viewFunc() external view returns (uint) {
        return num;   
    }

    function pureFunc() external pure returns (uint) {
        return 1;   
    }

    function addToNo(uint x) external view returns (uint) {
        return num + x;   
    }

    function add(uint x, uint y) external pure returns (uint) {
        return x + y;   
    }


    
}