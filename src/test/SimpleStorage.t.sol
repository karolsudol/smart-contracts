// SPDX-License-Identifier: MIT

pragma solidity ^0.8.12;

// import "/ds-test/test.sol";
import "../../lib/ds-test/src/test.sol";
import "../SimpleStorage.sol";

interface VM {
    function warp(uint256 x) external; // move fwd in tinme
    function prank(address sender) external; // run next tx given the address
    function deal(address, uint256) external; // get ETH val of given address
}

contract SimpleStorageTest is DSTest {
    SimpleStorage private simpleStorage;
    VM vm = VM(0x7109709ECfa91a80626fF3989D68f67F5b1DD12D);

    function setUp() public {
        simpleStorage = new SimpleStorage();
    }

    function test_StoreRetrieve() public {
        simpleStorage.store(1);
        assertEq(1, simpleStorage.retrieve());
    }

    function testFail_StoreRetrieve() public {
        simpleStorage.store(1);
        assertEq(2, simpleStorage.retrieve());
    }

    function test_AddPerson() public {
        // simpleStorage.addPerson("one", 1);
        
        // assertEq(simpleStorage.people[1]._name, "one");
    }

    

    // addPerson

}