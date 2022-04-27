// SPDX-License-Identifier: MIT
pragma solidity ^0.8.13;

contract Mappings {
    mapping(address => uint) public balances;
    mapping(address => bool) public inserted;
    mapping(address=>mapping (address=>bool)) public isFriend;
    address[] public keys;

    function set(address _key, uint _val) external {
        balances[_key] = _val;

        if (!inserted[_key]) {
            inserted[_key] = true;
            keys.push(_key);   
        }    
    }

    function getSize() external view returns (uint){
            return keys.length;   
    }

    function first() external view returns (uint){
            return balances[keys[0]];   
    }

    function last() external view returns (uint){
            return balances[keys[keys.length -1]];   
    }


    function get(uint _i) external view returns (uint){
            return balances[keys[_i]];   
    }

    function expamples() external {
        balances[msg.sender] = 123;
        uint bal1 = balances[msg.sender];
        uint bal2 = balances[address(1)]; // 0
        
        bal1 += 456;
        bal2 += 123;
        delete balances[msg.sender];
        isFriend[msg.sender][address(this)] = true;  
    }

}