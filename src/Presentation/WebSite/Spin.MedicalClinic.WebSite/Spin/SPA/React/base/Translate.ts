/**
 * Translate
 * @param _key
 * @param _replace
 */
export function Translate(_key: string, _replace: string[] = []) {
	let translate = document.querySelector("react-translate");
	let result: string = translate ? translate.getAttribute(`data-${_key.toLowerCase()}`): null;

	if (result) {
		_replace.forEach(element => {
			result = result.replace("?", element);
		});
	} else {
		result = _key;
	}

	return result;
};