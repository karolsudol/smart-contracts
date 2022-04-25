// SPDX-License-Identifier: MIT
pragma solidity ^0.8.12;

contract AddSub {
    function add(uint256 x, uint256 y) external pure returns (uint256){
        require((x | y ) > 0, "x | y < 0");
        return x + y;
    }

    function sub(uint256 x, uint256 y) external pure returns (uint256){
        require((x | y ) > 0, "x | y < 0");
        return x - y;
    }
    
}