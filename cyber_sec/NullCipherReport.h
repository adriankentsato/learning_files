// C++ program to decode NULL CIPHER

#include <bits/stdc++.h>
using namespace std;

// Function to decode the message.
string decode(string str)
{
	// Store the decoded string.
	string res = "";
	// found variable is used to tell that the encoded
	// encoded character is found in that particular word.
	bool found = false;
	
	for (int i = 0; i < str.size(); i++) {
	// Set found variable to false whenever we find
	// whitespace, meaning that encoded character for
	// new word is not found
	if(str[i] == ' ')
	{
	found = false;
	continue;
	}
	if(!found)
	{
	if( str[i] >= 'A' && str[i] <= 'Z')
	{
		res += str[i] + 32;
	found = true;
	}
	else if(str[i] >= 'a' && str[i] <= 'z')
	{
		res += str[i];
	found = true;
	}
	}
}
return res;
}

// Driver code
int main()
{
	string data_input;
	data_input = "A Step by Step Guide for Placement Preparation by GeeksforGeeks";
	
	cout << "Enciphered Message: ";
	
	// Function call
	cout << decode(data_input) << endl;
	return 0;
}
