public class CustomerDiscountStragetyFactory {
    public IDiscountStragety CreateCustomerDiscountStragety(States state) {
        
        if (state == States.Silver) 
            return new SilverCustomerDiscountStargety();
        else if (state == States.Gold ) 
            return new GoldCustomerDiscountStargety();
        else if (state == States.New)
            return  new NewCustomerDiscountStargety();

        // this related to the NullObjects design pattern 
        return new NullCustomerDiscountStragety();
        
    }
}