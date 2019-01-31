2.INSERTING NODE AT nTH POSITION

struct Node {
	int data;
	struct Node* next;
};

struct Node* head;

void Insert(int data, int n) {
	Node* temp1 = new Node();
	temp1->data = data;
	temp1->next = NULL;
	if (n == 1) {
		temp1->next = head;
		head = temp1;
		return;
	}
	Node* temp2 = head;
	for (int i = 0; i < n - 2; i++) {
		if(temp2 == null)
		{
			return;
		}
		temp2 = temp2->next;
	}
	temp1->next = temp2->next;
	temp2->next = temp1;
}

void Print() {
	Node* temp = head;
	while (temp != NULL) {
		printf("%d", temp->data);
		temp = temp->next;
	}
	printf("/n");
}

int main() {
	head = NULL;
	Insert(2, 1); //2
	Insert(3, 2); //3 2
	Insert(4, 1); //4 3 2
	Insert(5, 2); // 4 5 3 2
	Print();
	getchar();
}