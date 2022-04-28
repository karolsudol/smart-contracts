// SPDX-License-Identifier: UNLICENSED
pragma solidity ^0.8.13;

// import "lib/ds-test/src/test.sol";
import "ds-test/test.sol";
import "../Contract.sol";

interface VM {
    function warp(uint256 x) external; // move fwd in tinme
    function prank(address sender) external; // run next tx given the address
    function deal(address, uint256) external; // get ETH val of given address
}

contract ContractTest is DSTest {
    Contract public myContract;
    VM vm = VM(0x7109709ECfa91a80626fF3989D68f67F5b1DD12D);

    function setUp() public {
        myContract = new Contract();
    }

    function test_setNumber() public {
        assertTrue(myContract.number() == 0);

        myContract.setNumber(777);
        assertTrue(myContract.number() == 777);
    }

    function testFail_setNumber() public {
        assertTrue(myContract.number() == 1);

        myContract.setNumber(777);
        assertTrue(myContract.number() == 888);
    }

    function testFuzz_setNumber(uint _num) public {
        myContract.setNumber(_num);
        assertTrue(myContract.number() == _num);
    }

    function test_warp() public {
        assertEq(block.timestamp, 0);
        vm.warp(100);
        assertEq(block.timestamp, 100);
    }



    
}