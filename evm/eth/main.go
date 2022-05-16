package main

import (
	"context"
	"evm/eth/account"
	"evm/eth/contracts/hello"
	"fmt"
	"math/big"
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

	// fmt.Printf("%+v\n", account)

	balanace, err := account.GetWeiBalance(address)
	if err != nil {
		log.WithFields(
			log.Fields{
				"msg": "balance failed",
			},
		).Fatal(err)
	}

	log.WithFields(
		log.Fields{
			"Wei":  balanace.String(),
			"Gwei": new(big.Int).Div(balanace, new(big.Int).SetInt64(1000000000)).String(),
			"ETH":  new(big.Int).Div(balanace, new(big.Int).SetInt64(1000000000000000000)).String(),
		},
	).Info("balance")

	addressHello := common.HexToAddress("0x5fbdb2315678afecb367f032d93f642f64180aa3")
	instance, err := hello.NewHello(addressHello, clinet)
	if err != nil {
		log.Fatal(err)
	}

	helloMsg, err := instance.Hello(nil)
	if err != nil {
		log.Fatal(err)
	}

	fmt.Println(helloMsg)

	result, err := instance.Greet(nil, "booha")
	if err != nil {
		log.Fatal(err)
	}

	fmt.Println(string(result[:]))

	// fmt.Printf("%+v\n", balanace.String())

}
