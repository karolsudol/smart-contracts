// SPDX-License-Identifier: UNLICENSED
pragma solidity ^0.8.12;

// import "lib/ds-test/src/test.sol";
import "ds-test/test.sol";
import "../Contract.sol";

contract ContractTest is DSTest {
    Contract public myContract;

    function setUp() public {
        myContract = new Contract();
    }

    function test_Initialised() public {
        assertTrue(myContract.number() == 0);

        myContract.setNumber(777);
        assertTrue(myContract.number() == 777);
    }



    
}