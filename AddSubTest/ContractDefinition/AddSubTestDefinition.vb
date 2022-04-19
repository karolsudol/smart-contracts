Imports System
Imports System.Threading.Tasks
Imports System.Collections.Generic
Imports System.Numerics
Imports Nethereum.Hex.HexTypes
Imports Nethereum.ABI.FunctionEncoding.Attributes
Imports Nethereum.Web3
Imports Nethereum.RPC.Eth.DTOs
Imports Nethereum.Contracts.CQS
Imports Nethereum.Contracts
Imports System.Threading
Namespace SmartContracts.Contracts.AddSubTest.ContractDefinition

    
    
    Public Partial Class AddSubTestDeployment
     Inherits AddSubTestDeploymentBase
    
        Public Sub New()
            MyBase.New(DEFAULT_BYTECODE)
        End Sub
        
        Public Sub New(ByVal byteCode As String)
            MyBase.New(byteCode)
        End Sub
    
    End Class

    Public Class AddSubTestDeploymentBase 
            Inherits ContractDeploymentMessage
        
        Public Shared DEFAULT_BYTECODE As String = "60806040526000805460ff1916600117905534801561001d57600080fd5b50610bb28061002d6000396000f3fe608060405234801561001057600080fd5b50600436106100935760003560e01c80632db0ee45116100665780632db0ee45146100c557806391763b07146100d857806398222acb146100e0578063ba414fa6146100e8578063fa7626d41461010457600080fd5b8063021f2e4d146100985780630a9254e4146100ad5780631e6dfae9146100b557806329dbf7fd146100bd575b600080fd5b6100ab6100a6366004610930565b610111565b005b6100ab6101a0565b6100ab6101f1565b6100ab6102b7565b6100ab6100d3366004610930565b6103be565b6100ab610444565b6100ab610507565b6100f06105ca565b604051901515815260200160405180910390f35b6000546100f09060ff1681565b60005460405163b67d77c560e01b8152600481018490526024810183905261019c916201000090046001600160a01b03169063b67d77c590604401602060405180830381865afa158015610169573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061018d9190610952565b6101978385610981565b6106f5565b5050565b6040516101ac90610923565b604051809103906000f0801580156101c8573d6000803e3d6000fd5b50600060026101000a8154816001600160a01b0302191690836001600160a01b03160217905550565b60005460405163b67d77c560e01b81526002600482015260016024820152610275916201000090046001600160a01b03169063b67d77c5906044015b602060405180830381865afa15801561024a573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061026e9190610952565b60026106f5565b60005460405163b67d77c560e01b815260016004820181905260248201526102b5916201000090046001600160a01b03169063b67d77c59060440161022d565b565b60005460405163771602f760e01b8152600160048201526002602482015261033a916201000090046001600160a01b03169063771602f790604401602060405180830381865afa15801561030f573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906103339190610952565b60046106f5565b60005460405163771602f760e01b815260016004820181905260248201526102b5916201000090046001600160a01b03169063771602f7906044015b602060405180830381865afa158015610393573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906103b79190610952565b60016106f5565b60005460405163771602f760e01b8152600481018490526024810183905261019c916201000090046001600160a01b03169063771602f790604401602060405180830381865afa158015610416573d6000803e3d6000fd5b505050506040513d601f19601f8201168201806040525081019061043a9190610952565b6101978385610998565b60005460405163b67d77c560e01b81526002600482015260016024820152610484916201000090046001600160a01b03169063b67d77c590604401610376565b60005460405163b67d77c560e01b815260016004820181905260248201526102b5916201000090046001600160a01b03169063b67d77c590604401602060405180830381865afa1580156104dc573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906105009190610952565b60006106f5565b60005460405163771602f760e01b8152600160048201526002602482015261058a916201000090046001600160a01b03169063771602f790604401602060405180830381865afa15801561055f573d6000803e3d6000fd5b505050506040513d601f19601f820116820180604052508101906105839190610952565b60036106f5565b60005460405163771602f760e01b815260016004820181905260248201526102b5916201000090046001600160a01b03169063771602f79060440161022d565b60008054610100900460ff16156105ea5750600054610100900460ff1690565b6000737109709ecfa91a80626ff3989d68f67f5b1dd12d3b156106f05760408051737109709ecfa91a80626ff3989d68f67f5b1dd12d602082018190526519985a5b195960d21b82840152825180830384018152606083019093526000929091610678917f667f9d70ca411d70ead50d8d5c22070dafc36ad75f3dcf5e7237b22ade9aecc4916080016109eb565b60408051601f198184030181529082905261069291610a0f565b6000604051808303816000865af19150503d80600081146106cf576040519150601f19603f3d011682016040523d82523d6000602084013e6106d4565b606091505b50915050808060200190518101906106ec9190610a22565b9150505b919050565b80821461019c577f41304facd9323d75b11bcdd609cb38effffdb05710f7caf0e9b16c6d9d709f506040516107669060208082526022908201527f4572726f723a2061203d3d2062206e6f7420736174697366696564205b75696e604082015261745d60f01b606082015260800190565b60405180910390a160408051818152600a81830152690808115e1c1958dd195960b21b60608201526020810183905290517fb2de2fbe801a0df6c0cbddfd448ba3c41d48a040ca35c56c8196ef0fcae721a89181900360800190a160408051818152600a8183015269080808081058dd1d585b60b21b60608201526020810184905290517fb2de2fbe801a0df6c0cbddfd448ba3c41d48a040ca35c56c8196ef0fcae721a89181900360800190a161019c737109709ecfa91a80626ff3989d68f67f5b1dd12d3b156109125760408051737109709ecfa91a80626ff3989d68f67f5b1dd12d602082018190526519985a5b195960d21b9282019290925260016060820152600091907f70ca10bbd0dbfd9020a9f4b13402c16cb120705e0d1c0aeab10fa353ae586fc49060800160408051601f19818403018152908290526108b192916020016109eb565b60408051601f19818403018152908290526108cb91610a0f565b6000604051808303816000865af19150503d8060008114610908576040519150601f19603f3d011682016040523d82523d6000602084013e61090d565b606091505b505050505b6000805461ff001916610100179055565b61013880610a4583390190565b6000806040838503121561094357600080fd5b50508035926020909101359150565b60006020828403121561096457600080fd5b5051919050565b634e487b7160e01b600052601160045260246000fd5b6000828210156109935761099361096b565b500390565b600082198211156109ab576109ab61096b565b500190565b6000815160005b818110156109d157602081850181015186830152016109b7565b818111156109e0576000828601525b509290920192915050565b6001600160e01b0319831681526000610a0760048301846109b0565b949350505050565b6000610a1b82846109b0565b9392505050565b600060208284031215610a3457600080fd5b81518015158114610a1b57600080fdfe608060405234801561001057600080fd5b50610118806100206000396000f3fe6080604052348015600f57600080fd5b506004361060325760003560e01c8063771602f7146037578063b67d77c5146058575b600080fd5b604660423660046082565b6067565b60405190815260200160405180910390f35b604660633660046082565b6078565b60006071828460b9565b9392505050565b60006071828460ce565b60008060408385031215609457600080fd5b50508035926020909101359150565b634e487b7160e01b600052601160045260246000fd5b6000821982111560c95760c960a3565b500190565b60008282101560dd5760dd60a3565b50039056fea264697066735822122040e4aa61a8952d6dd4f9eb1a29accd252579ea56f85058341c59578bfc8d195764736f6c634300080d0033a26469706673582212202697c3f4d4e438d463c4c9da1def5b7c14ce986d932819097af6f9c49a00c19d64736f6c634300080d0033"
        
        Public Sub New()
            MyBase.New(DEFAULT_BYTECODE)
        End Sub
        
        Public Sub New(ByVal byteCode As String)
            MyBase.New(byteCode)
        End Sub
        

    
    End Class    
    
    Public Partial Class IS_TESTFunction
        Inherits IS_TESTFunctionBase
    End Class

        <[Function]("IS_TEST", "bool")>
    Public Class IS_TESTFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class FailedFunction
        Inherits FailedFunctionBase
    End Class

        <[Function]("failed", "bool")>
    Public Class FailedFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class SetUpFunction
        Inherits SetUpFunctionBase
    End Class

        <[Function]("setUp")>
    Public Class SetUpFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class TestFail_AddFunction
        Inherits TestFail_AddFunctionBase
    End Class

        <[Function]("testFail_Add")>
    Public Class TestFail_AddFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class TestFail_SubFunction
        Inherits TestFail_SubFunctionBase
    End Class

        <[Function]("testFail_Sub")>
    Public Class TestFail_SubFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class TestFuzz_AddFunction
        Inherits TestFuzz_AddFunctionBase
    End Class

        <[Function]("testFuzz_Add")>
    Public Class TestFuzz_AddFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("uint256", "x", 1)>
        Public Overridable Property [X] As BigInteger
        <[Parameter]("uint256", "y", 2)>
        Public Overridable Property [Y] As BigInteger
    
    End Class
    
    
    Public Partial Class TestFuzz_SubFunction
        Inherits TestFuzz_SubFunctionBase
    End Class

        <[Function]("testFuzz_Sub")>
    Public Class TestFuzz_SubFunctionBase
        Inherits FunctionMessage
    
        <[Parameter]("uint256", "x", 1)>
        Public Overridable Property [X] As BigInteger
        <[Parameter]("uint256", "y", 2)>
        Public Overridable Property [Y] As BigInteger
    
    End Class
    
    
    Public Partial Class Test_AddFunction
        Inherits Test_AddFunctionBase
    End Class

        <[Function]("test_Add")>
    Public Class Test_AddFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class Test_SubFunction
        Inherits Test_SubFunctionBase
    End Class

        <[Function]("test_Sub")>
    Public Class Test_SubFunctionBase
        Inherits FunctionMessage
    

    
    End Class
    
    
    Public Partial Class LogEventDTO
        Inherits LogEventDTOBase
    End Class

    <[Event]("log")>
    Public Class LogEventDTOBase
        Implements IEventDTO
        
        <[Parameter]("string", "", 1, false)>
        Public Overridable Property [ReturnValue1] As String
    
    End Class    
    
    Public Partial Class Log_addressEventDTO
        Inherits Log_addressEventDTOBase
    End Class

    <[Event]("log_address")>
    Public Class Log_addressEventDTOBase
        Implements IEventDTO
        
        <[Parameter]("address", "", 1, false)>
        Public Overridable Property [ReturnValue1] As String
    
    End Class    
    
    Public Partial Class Log_bytesEventDTO
        Inherits Log_bytesEventDTOBase
    End Class

    <[Event]("log_bytes")>
    Public Class Log_bytesEventDTOBase
        Implements IEventDTO
        
        <[Parameter]("bytes", "", 1, false)>
        Public Overridable Property [ReturnValue1] As Byte()
    
    End Class    
    
    Public Partial Class Log_bytes32EventDTO
        Inherits Log_bytes32EventDTOBase
    End Class

    <[Event]("log_bytes32")>
    Public Class Log_bytes32EventDTOBase
        Implements IEventDTO
        
        <[Parameter]("bytes32", "", 1, false)>
        Public Overridable Property [ReturnValue1] As Byte()
    
    End Class    
    
    Public Partial Class Log_intEventDTO
        Inherits Log_intEventDTOBase
    End Class

    <[Event]("log_int")>
    Public Class Log_intEventDTOBase
        Implements IEventDTO
        
        <[Parameter]("int256", "", 1, false)>
        Public Overridable Property [ReturnValue1] As BigInteger
    
    End Class    
    
    Public Partial Class Log_named_addressEventDTO
        Inherits Log_named_addressEventDTOBase
    End Class

    <[Event]("log_named_address")>
    Public Class Log_named_addressEventDTOBase
        Implements IEventDTO
        
        <[Parameter]("string", "key", 1, false)>
        Public Overridable Property [Key] As String
        <[Parameter]("address", "val", 2, false)>
        Public Overridable Property [Val] As String
    
    End Class    
    
    Public Partial Class Log_named_bytesEventDTO
        Inherits Log_named_bytesEventDTOBase
    End Class

    <[Event]("log_named_bytes")>
    Public Class Log_named_bytesEventDTOBase
        Implements IEventDTO
        
        <[Parameter]("string", "key", 1, false)>
        Public Overridable Property [Key] As String
        <[Parameter]("bytes", "val", 2, false)>
        Public Overridable Property [Val] As Byte()
    
    End Class    
    
    Public Partial Class Log_named_bytes32EventDTO
        Inherits Log_named_bytes32EventDTOBase
    End Class

    <[Event]("log_named_bytes32")>
    Public Class Log_named_bytes32EventDTOBase
        Implements IEventDTO
        
        <[Parameter]("string", "key", 1, false)>
        Public Overridable Property [Key] As String
        <[Parameter]("bytes32", "val", 2, false)>
        Public Overridable Property [Val] As Byte()
    
    End Class    
    
    Public Partial Class Log_named_decimal_intEventDTO
        Inherits Log_named_decimal_intEventDTOBase
    End Class

    <[Event]("log_named_decimal_int")>
    Public Class Log_named_decimal_intEventDTOBase
        Implements IEventDTO
        
        <[Parameter]("string", "key", 1, false)>
        Public Overridable Property [Key] As String
        <[Parameter]("int256", "val", 2, false)>
        Public Overridable Property [Val] As BigInteger
        <[Parameter]("uint256", "decimals", 3, false)>
        Public Overridable Property [Decimals] As BigInteger
    
    End Class    
    
    Public Partial Class Log_named_decimal_uintEventDTO
        Inherits Log_named_decimal_uintEventDTOBase
    End Class

    <[Event]("log_named_decimal_uint")>
    Public Class Log_named_decimal_uintEventDTOBase
        Implements IEventDTO
        
        <[Parameter]("string", "key", 1, false)>
        Public Overridable Property [Key] As String
        <[Parameter]("uint256", "val", 2, false)>
        Public Overridable Property [Val] As BigInteger
        <[Parameter]("uint256", "decimals", 3, false)>
        Public Overridable Property [Decimals] As BigInteger
    
    End Class    
    
    Public Partial Class Log_named_intEventDTO
        Inherits Log_named_intEventDTOBase
    End Class

    <[Event]("log_named_int")>
    Public Class Log_named_intEventDTOBase
        Implements IEventDTO
        
        <[Parameter]("string", "key", 1, false)>
        Public Overridable Property [Key] As String
        <[Parameter]("int256", "val", 2, false)>
        Public Overridable Property [Val] As BigInteger
    
    End Class    
    
    Public Partial Class Log_named_stringEventDTO
        Inherits Log_named_stringEventDTOBase
    End Class

    <[Event]("log_named_string")>
    Public Class Log_named_stringEventDTOBase
        Implements IEventDTO
        
        <[Parameter]("string", "key", 1, false)>
        Public Overridable Property [Key] As String
        <[Parameter]("string", "val", 2, false)>
        Public Overridable Property [Val] As String
    
    End Class    
    
    Public Partial Class Log_named_uintEventDTO
        Inherits Log_named_uintEventDTOBase
    End Class

    <[Event]("log_named_uint")>
    Public Class Log_named_uintEventDTOBase
        Implements IEventDTO
        
        <[Parameter]("string", "key", 1, false)>
        Public Overridable Property [Key] As String
        <[Parameter]("uint256", "val", 2, false)>
        Public Overridable Property [Val] As BigInteger
    
    End Class    
    
    Public Partial Class Log_stringEventDTO
        Inherits Log_stringEventDTOBase
    End Class

    <[Event]("log_string")>
    Public Class Log_stringEventDTOBase
        Implements IEventDTO
        
        <[Parameter]("string", "", 1, false)>
        Public Overridable Property [ReturnValue1] As String
    
    End Class    
    
    Public Partial Class Log_uintEventDTO
        Inherits Log_uintEventDTOBase
    End Class

    <[Event]("log_uint")>
    Public Class Log_uintEventDTOBase
        Implements IEventDTO
        
        <[Parameter]("uint256", "", 1, false)>
        Public Overridable Property [ReturnValue1] As BigInteger
    
    End Class    
    
    Public Partial Class LogsEventDTO
        Inherits LogsEventDTOBase
    End Class

    <[Event]("logs")>
    Public Class LogsEventDTOBase
        Implements IEventDTO
        
        <[Parameter]("bytes", "", 1, false)>
        Public Overridable Property [ReturnValue1] As Byte()
    
    End Class    
    
    Public Partial Class IS_TESTOutputDTO
        Inherits IS_TESTOutputDTOBase
    End Class

    <[FunctionOutput]>
    Public Class IS_TESTOutputDTOBase
        Implements IFunctionOutputDTO
        
        <[Parameter]("bool", "", 1)>
        Public Overridable Property [ReturnValue1] As Boolean
    
    End Class    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    

End Namespace
