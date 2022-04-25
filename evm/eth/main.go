package main

import (
	"context"
	"evm/eth/account"
	"fmt"
	"os"

	log "github.com/sirupsen/logrus"

	"github.com/ethereum/go-ethereum/common"
	"github.com/ethereum/go-ethereum/ethclient"
)

func main() {

	rawUrl := "http://127.0.0.1:8545"
	rawAddress := "0xf39fd6e51aad88f6f4ce6ab8827279cfffb92266"

	// log.SetFormatter(&log.JSONFormatter{})
	customFormatter := new(log.JSONFormatter)
	customFormatter.TimestampFormat = "02-01-2006 15:04:05"
	log.SetFormatter(customFormatter)
	log.SetOutput(os.Stdout)

	ctx := context.Background()

	clinet, err := ethclient.Dial(rawUrl)
	if err != nil {
		log.WithFields(
			log.Fields{
				"msg": "eth client failed to load",
			},
		).Fatal(err)
	}
	address := common.HexToAddress(rawAddress)

	account := account.Account{
		Ctx:     ctx,
		Client:  clinet,
		Address: address,
	}

	fmt.Printf("%+v\n", account)

}

// Instantiate the contract and display its name
// token, err := NewToken(common.HexToAddress("0x21e6fc92f93c8a1bb41e2be64b4e1f88a54d3576"), conn)
// if err != nil {
// 	log.Fatalf("Failed to instantiate a Token contract: %v", err)
// }
// name, err := token.Name(nil)
// if err != nil {
// 	log.Fatalf("Failed to retrieve token name: %v", err)
// }
// fmt.Println("Token name:", name)
