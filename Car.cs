// One way of doing Properties
class Car {

    private string carName;

    public string getCarName() {
        return carName;
    }

    public void setCarName(string carName) {
        this.carName = carName;
    }

}


// Another way of doing properties

class Van {
    public string VanName { get; set; }
}

