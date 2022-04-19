// SPDX-License-Identifier: UNLICENSED
pragma solidity ^0.8.12;

contract Error {
    function requireFunc(uint _i) public pure {
        require(_i <= 10, "i > 10");
         // code  
    }

    function revertFunc(uint _i) public pure {
        if (_i > 1) {
            //code
            if (_i > 2) {
            //code 
            if(_i > 10) revert("i > 10");
            }   
        }    
    }

    error myError(address caller, uint i);


    function customErrFunc(uint _i) public view {
        if (_i > 10) {
            revert myError(msg.sender, _i);
        }
    }
}