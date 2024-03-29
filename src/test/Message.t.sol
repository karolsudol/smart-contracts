// SPDX-License-Identifier: MIT
pragma solidity ^0.8.12;

import "ds-test/test.sol";
import "../Message.sol";

interface VM {
    function warp(uint256 x) external; // move fwd in tinme
    function prank(address sender) external; // run next tx given the address
    function deal(address, uint256) external; // get ETH val of given address
}

contract MessageTest is DSTest {
    Message private message;
    VM vm = VM(0x7109709ECfa91a80626fF3989D68f67F5b1DD12D);

    function setUp() public {
        message = new Message();
    }

    function test_Deploy() public {
        assertEq("Hello", message.message());
    }

    function test_SetMessage() public {
        message.setMessage("Goodbye");
        assertEq("Goodbye", message.message());
    }

    function testFail_IfNotOwner() public {
        vm.prank(address(1));
        message.setMessage("Goodbye");
    }

    function testFail_IfUpdateTooSoon() public {
        vm.warp(1 days);
        message.setMessage("Goodbye");
        message.setMessage("Hello again");
    }

    function test_SetMessageWithBribe() public {
        vm.deal(address(1), 100 ether); //supply fake address with eth
        vm.prank(address(1)); // impersonate address
        message.setMessage{value: 1 ether}("Goodbye");
        assertEq("Goodbye", message.message());
    }

}